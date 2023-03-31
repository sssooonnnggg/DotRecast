/*
recast4j copyright (c) 2021 Piotr Piastucki piotr@jtilia.org

This software is provided 'as-is', without any express or implied
warranty.  In no event will the authors be held liable for any damages
arising from the use of this software.
Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:
1. The origin of this software must not be misrepresented; you must not
 claim that you wrote the original software. If you use this software
 in a product, an acknowledgment in the product documentation would be
 appreciated but is not required.
2. Altered source versions must be plainly marked as such, and must not be
 misrepresented as being the original software.
3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using DotRecast.Core;
using DotRecast.Detour.Dynamic.Io;
using DotRecast.Recast;
using Moq;
using NUnit.Framework;

namespace DotRecast.Detour.Dynamic.Test;

public class VoxelQueryTest
{
    private const int TILE_WIDTH = 100;
    private const int TILE_DEPTH = 90;
    private static readonly Vector3f ORIGIN = Vector3f.Of(50, 10, 40);


    [Test]
    public void shouldTraverseTiles()
    {
        var hfProvider = new Mock<Func<int, int, Heightfield>>();

        // Given
        List<int> captorX = new();
        List<int> captorZ = new();

        hfProvider
            .Setup(e => e.Invoke(It.IsAny<int>(), It.IsAny<int>()))
            .Returns((Heightfield)null)
            .Callback<int, int>((x, z) =>
            {
                captorX.Add(x);
                captorZ.Add(z);
            });

        VoxelQuery query = new VoxelQuery(ORIGIN, TILE_WIDTH, TILE_DEPTH, hfProvider.Object);
        Vector3f start = Vector3f.Of(120, 10, 365);
        Vector3f end = Vector3f.Of(320, 10, 57);

        // When
        query.raycast(start, end);
        // Then
        hfProvider.Verify(mock => mock.Invoke(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(6));
        Assert.That(captorX, Is.EqualTo(new[] { 0, 1, 1, 1, 2, 2 }));
        Assert.That(captorZ, Is.EqualTo(new[] { 3, 3, 2, 1, 1, 0 }));
    }

    [Test]
    public void shouldHandleRaycastWithoutObstacles()
    {
        DynamicNavMesh mesh = createDynaMesh();
        VoxelQuery query = mesh.voxelQuery();
        Vector3f start = Vector3f.Of(7.4f, 0.5f, -64.8f);
        Vector3f end = Vector3f.Of(31.2f, 0.5f, -75.3f);
        float? hit = query.raycast(start, end);
        Assert.That(hit, Is.Null);
    }

    [Test]
    public void shouldHandleRaycastWithObstacles()
    {
        DynamicNavMesh mesh = createDynaMesh();
        VoxelQuery query = mesh.voxelQuery();
        Vector3f start = Vector3f.Of(32.3f, 0.5f, 47.9f);
        Vector3f end = Vector3f.Of(-31.2f, 0.5f, -29.8f);
        float? hit = query.raycast(start, end);
        Assert.That(hit, Is.Not.Null);
        Assert.That(hit.Value, Is.EqualTo(0.5263836f).Within(1e-7f));
    }

    private DynamicNavMesh createDynaMesh()
    {
        var bytes = Loader.ToBytes("test_tiles.voxels");
        using var ms = new MemoryStream(bytes);
        using var bis = new BinaryReader(ms);

        // load voxels from file
        VoxelFileReader reader = new VoxelFileReader();
        VoxelFile f = reader.read(bis);
        // create dynamic navmesh
        var mesh = new DynamicNavMesh(f);
        // build navmesh asynchronously using multiple threads
        Task<bool> future = mesh.build(Task.Factory);
        // wait for build to complete
        var _ = future.Result;
        return mesh;
    }
}