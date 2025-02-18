/*
Copyright (c) 2009-2010 Mikko Mononen memon@inside.org
recast4j copyright (c) 2015-2019 Piotr Piastucki piotr@jtilia.org
DotRecast Copyright (c) 2023-2024 Choi Ikpil ikpil@naver.com

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

using NUnit.Framework;

namespace DotRecast.Detour.Crowd.Test;


public class Crowd4Test : AbstractCrowdTest
{
    static readonly float[][] EXPECTED_A1Q2TVTA =
    {
        new[] { 23.275612f, 10.197294f, -46.233074f, 0.061640f, 0.000000f, 0.073828f },
        new[] { 23.350517f, 10.197294f, -46.304905f, 0.030557f, 0.000000f, 0.118703f },
        new[] { 23.347885f, 10.197294f, -46.331837f, -0.024102f, 0.000000f, -0.093108f },
        new[] { 23.338102f, 10.197294f, -46.372726f, -0.048912f, 0.000000f, -0.204439f },
        new[] { 23.158630f, 10.197294f, -46.386150f, -0.897364f, 0.000000f, -0.067119f },
        new[] { 22.750568f, 10.197294f, -46.389927f, -2.040308f, 0.000000f, -0.018881f },
        new[] { 22.173302f, 10.197294f, -46.272018f, -2.886330f, 0.000000f, 0.589539f },
        new[] { 21.579432f, 10.197294f, -46.052692f, -2.969354f, 0.000000f, 1.096630f },
        new[] { 20.957502f, 10.197294f, -45.761692f, -3.109650f, 0.000000f, 1.455011f },
        new[] { 20.365976f, 10.197294f, -45.476425f, -2.957630f, 0.000000f, 1.426327f },
        new[] { 19.775288f, 10.197294f, -45.189430f, -2.953444f, 0.000000f, 1.434977f },
        new[] { 19.185482f, 10.197294f, -44.900627f, -2.949032f, 0.000000f, 1.444020f },
        new[] { 18.596607f, 10.197294f, -44.609928f, -2.944376f, 0.000000f, 1.453491f },
        new[] { 18.008717f, 10.197294f, -44.317242f, -2.939449f, 0.000000f, 1.463430f },
        new[] { 17.421871f, 10.197294f, -44.022465f, -2.934223f, 0.000000f, 1.473880f },
        new[] { 16.836138f, 10.197294f, -43.725487f, -2.928665f, 0.000000f, 1.484893f },
        new[] { 16.237518f, 10.197294f, -43.413433f, -2.993098f, 0.000000f, 1.560270f },
        new[] { 15.662568f, 10.197294f, -43.098225f, -2.874751f, 0.000000f, 1.576043f },
        new[] { 15.094946f, 10.197294f, -42.777035f, -2.838109f, 0.000000f, 1.605944f },
        new[] { 14.528272f, 10.197294f, -42.454178f, -2.833370f, 0.000000f, 1.614288f },
        new[] { 13.962630f, 10.197294f, -42.129513f, -2.828207f, 0.000000f, 1.623317f },
        new[] { 13.391782f, 10.197294f, -41.806934f, -2.854241f, 0.000000f, 1.612890f },
        new[] { 12.799945f, 10.197294f, -41.482201f, -2.959186f, 0.000000f, 1.623668f },
        new[] { 12.197092f, 10.197294f, -41.139999f, -3.014262f, 0.000000f, 1.711000f },
        new[] { 11.594053f, 10.197294f, -40.811634f, -3.015195f, 0.000000f, 1.641821f },
        new[] { 10.996500f, 10.197294f, -40.460262f, -2.987766f, 0.000000f, 1.756859f },
        new[] { 10.401724f, 10.197294f, -40.104210f, -2.973881f, 0.000000f, 1.780260f },
        new[] { 9.810114f, 10.197294f, -39.742920f, -2.958048f, 0.000000f, 1.806445f },
        new[] { 9.222152f, 10.197294f, -39.375725f, -2.939809f, 0.000000f, 1.835979f },
        new[] { 8.638441f, 10.197294f, -39.001808f, -2.918552f, 0.000000f, 1.869585f },
        new[] { 8.059751f, 10.197294f, -38.620167f, -2.893450f, 0.000000f, 1.908203f },
        new[] { 7.536088f, 10.197294f, -38.213108f, -2.618314f, 0.000000f, 2.035301f },
        new[] { 7.008043f, 10.197294f, -37.798481f, -2.640225f, 0.000000f, 2.073141f },
        new[] { 6.484523f, 10.197294f, -37.378155f, -2.617601f, 0.000000f, 2.101635f },
        new[] { 5.957591f, 10.197294f, -36.962112f, -2.634658f, 0.000000f, 2.080211f },
        new[] { 5.458399f, 10.197294f, -36.525387f, -2.495958f, 0.000000f, 2.183624f },
        new[] { 4.952830f, 10.197294f, -36.083633f, -2.527847f, 0.000000f, 2.208776f },
        new[] { 4.445582f, 10.197294f, -35.638187f, -2.536238f, 0.000000f, 2.227235f },
        new[] { 3.997866f, 10.197294f, -35.100090f, -2.238582f, 0.000000f, 2.690493f },
        new[] { 3.604921f, 10.197294f, -34.520786f, -1.964725f, 0.000000f, 2.896524f },
        new[] { 3.216267f, 10.197294f, -33.938595f, -1.943270f, 0.000000f, 2.910962f },
        new[] { 2.839496f, 10.197294f, -33.348644f, -1.883856f, 0.000000f, 2.949760f },
        new[] { 2.482899f, 10.197294f, -32.746284f, -1.782983f, 0.000000f, 3.011806f },
        new[] { 2.165045f, 10.197294f, -32.122612f, -1.589272f, 0.000000f, 3.118367f },
        new[] { 1.968905f, 10.197294f, -31.542366f, -0.980699f, 0.000000f, 2.901230f },
        new[] { 1.830858f, 10.197294f, -30.899487f, -0.690238f, 0.000000f, 3.214399f },
        new[] { 1.790072f, 10.197294f, -30.240873f, -0.203930f, 0.000000f, 3.293068f },
        new[] { 1.860591f, 10.197294f, -29.561634f, 0.352598f, 0.000000f, 3.396194f },
        new[] { 2.125831f, 10.197294f, -28.913832f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 2.391070f, 10.197294f, -28.266029f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 2.656309f, 10.197294f, -27.618227f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 2.921549f, 10.197294f, -26.970425f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 3.186788f, 10.197294f, -26.322622f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 3.452027f, 10.197294f, -25.674820f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 3.717267f, 10.197294f, -25.027018f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 3.982506f, 10.197294f, -24.379215f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 4.247745f, 10.197294f, -23.731413f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 4.512984f, 10.197294f, -23.083611f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 4.778224f, 10.197294f, -22.435808f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 5.043463f, 10.197294f, -21.788006f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 5.308702f, 10.197294f, -21.140203f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 5.573941f, 10.197294f, -20.492401f, 1.326197f, 0.000000f, 3.239013f },
        new[] { 5.839180f, 10.197294f, -19.844599f, 1.326197f, 0.000000f, 3.239012f },
        new[] { 6.173420f, 10.197294f, -19.342373f, 1.706390f, 0.000000f, 2.813494f },
        new[] { 6.501637f, 10.197294f, -19.076807f, 1.451270f, 0.000000f, 2.463549f },
        new[] { 6.803561f, 10.197294f, -18.729990f, 1.002026f, 0.000000f, 2.679962f },
        new[] { 6.799414f, 10.197294f, -18.366598f, -0.993883f, 0.000000f, 1.390529f },
        new[] { 6.990967f, 10.197294f, -18.240343f, 2.109758f, 0.000000f, 0.180499f },
        new[] { 7.157530f, 10.197294f, -18.320511f, 0.758936f, 0.000000f, 0.228570f },
        new[] { 7.349619f, 10.197294f, -18.347782f, 0.926001f, 0.000000f, 0.008640f },
        new[] { 7.448954f, 10.197294f, -18.390112f, 0.496676f, 0.000000f, -0.211644f },
        new[] { 7.524421f, 10.197294f, -18.477961f, 0.377335f, 0.000000f, -0.439247f },
        new[] { 7.628986f, 10.197294f, -18.484478f, 0.522823f, 0.000000f, -0.032589f },
        new[] { 7.751089f, 10.197294f, -18.466608f, 0.610513f, 0.000000f, 0.089349f },
        new[] { 7.891870f, 10.197294f, -18.490461f, 0.703905f, 0.000000f, -0.119263f },
        new[] { 8.032493f, 10.197294f, -18.515228f, 0.703115f, 0.000000f, -0.123836f },
        new[] { 8.172967f, 10.1862135f, -18.540827f, 0.702371f, 0.000000f, -0.127992f },
        new[] { 8.182732f, 10.1862135f, -18.626057f, 0.048824f, 0.000000f, -0.426151f },
        new[] { 8.165586f, 10.188671f, -18.846558f, -0.085729f, 0.000000f, -1.102502f },
        new[] { 8.048562f, 10.197294f, -18.763044f, -0.785845f, 0.000000f, 1.028553f },
        new[] { 7.802718f, 10.197294f, -18.943884f, -1.229222f, 0.000000f, -0.904202f },
        new[] { 7.655485f, 10.197294f, -19.137533f, -0.736162f, 0.000000f, -0.968250f },
        new[] { 7.542105f, 10.197294f, -19.244339f, -0.566899f, 0.000000f, -0.534033f },
        new[] { 7.427822f, 10.197294f, -19.031147f, -0.572634f, 0.000000f, 1.497748f },
        new[] { 7.339287f, 10.197294f, -18.757444f, -0.442677f, 0.000000f, 1.368514f },
        new[] { 7.255370f, 10.197294f, -18.471191f, -0.419582f, 0.000000f, 1.431268f },
        new[] { 7.153419f, 10.197294f, -18.314838f, -0.509755f, 0.000000f, 0.781767f },
        new[] { 7.129016f, 10.197294f, -18.194052f, -0.122013f, 0.000000f, 0.603930f },
        new[] { 7.099013f, 10.197294f, -18.064573f, -0.150015f, 0.000000f, 0.647393f },
        new[] { 7.085871f, 10.197294f, -17.946556f, -0.065714f, 0.000000f, 0.590090f },
        new[] { 7.067722f, 10.197294f, -17.801628f, -0.090745f, 0.000000f, 0.724639f },
        new[] { 7.048226f, 10.197294f, -17.673695f, -0.097479f, 0.000000f, 0.639666f }
    };

    static readonly float[][] EXPECTED_A1Q2TVTAS =
    {
        new[] { 23.253357f, 10.197294f, -46.279934f, 0.074597f, 0.000000f, -0.017069f },
        new[] { 23.336805f, 10.197294f, -46.374985f, 0.119401f, 0.000000f, -0.031009f },
        new[] { 23.351542f, 10.197294f, -46.410728f, 0.053426f, 0.000000f, -0.093556f },
        new[] { 23.362417f, 10.197294f, -46.429638f, 0.054377f, 0.000000f, -0.094549f },
        new[] { 23.216995f, 10.197294f, -46.446442f, -0.727108f, 0.000000f, -0.084018f },
        new[] { 22.902132f, 10.197294f, -46.426094f, -1.574317f, 0.000000f, 0.101733f },
        new[] { 22.491152f, 10.197294f, -46.376247f, -2.054897f, 0.000000f, 0.249239f },
        new[] { 22.058567f, 10.197294f, -46.289536f, -2.162925f, 0.000000f, 0.433569f },
        new[] { 21.588501f, 10.197294f, -46.183846f, -2.350327f, 0.000000f, 0.528449f },
        new[] { 21.116070f, 10.197294f, -46.072765f, -2.362152f, 0.000000f, 0.555402f },
        new[] { 20.642447f, 10.197294f, -45.954391f, -2.368116f, 0.000000f, 0.591867f },
        new[] { 20.168785f, 10.197294f, -45.827782f, -2.368307f, 0.000000f, 0.633050f },
        new[] { 19.695480f, 10.197294f, -45.692959f, -2.366527f, 0.000000f, 0.674118f },
        new[] { 19.221388f, 10.197294f, -45.549664f, -2.370462f, 0.000000f, 0.716482f },
        new[] { 18.747715f, 10.197294f, -45.401028f, -2.368369f, 0.000000f, 0.743186f },
        new[] { 18.274532f, 10.197294f, -45.247219f, -2.365911f, 0.000000f, 0.769049f },
        new[] { 17.801916f, 10.197294f, -45.088371f, -2.363083f, 0.000000f, 0.794239f },
        new[] { 17.329977f, 10.197294f, -44.924515f, -2.359692f, 0.000000f, 0.819281f },
        new[] { 16.858923f, 10.197294f, -44.755489f, -2.355273f, 0.000000f, 0.845136f },
        new[] { 16.389112f, 10.197294f, -44.580818f, -2.349057f, 0.000000f, 0.873354f },
        new[] { 15.904601f, 10.197294f, -44.397808f, -2.422558f, 0.000000f, 0.915057f },
        new[] { 15.422479f, 10.197294f, -44.204182f, -2.410610f, 0.000000f, 0.968130f },
        new[] { 14.943066f, 10.197294f, -44.000332f, -2.397065f, 0.000000f, 1.019240f },
        new[] { 14.466599f, 10.197294f, -43.786751f, -2.382330f, 0.000000f, 1.067903f },
        new[] { 13.993264f, 10.197294f, -43.563339f, -2.366675f, 0.000000f, 1.117066f },
        new[] { 13.539879f, 10.197294f, -43.333740f, -2.266925f, 0.000000f, 1.147989f },
        new[] { 13.089582f, 10.197294f, -43.096500f, -2.251482f, 0.000000f, 1.186200f },
        new[] { 12.642441f, 10.197294f, -42.852135f, -2.235710f, 0.000000f, 1.221827f },
        new[] { 12.198518f, 10.197294f, -42.601135f, -2.219616f, 0.000000f, 1.254998f },
        new[] { 11.757890f, 10.197294f, -42.343952f, -2.203139f, 0.000000f, 1.285906f },
        new[] { 11.320659f, 10.197294f, -42.080994f, -2.186156f, 0.000000f, 1.314789f },
        new[] { 10.886962f, 10.197294f, -41.812611f, -2.168484f, 0.000000f, 1.341919f },
        new[] { 10.456985f, 10.197294f, -41.539093f, -2.149882f, 0.000000f, 1.367595f },
        new[] { 10.030977f, 10.197294f, -41.260666f, -2.130040f, 0.000000f, 1.392133f },
        new[] { 9.609450f, 10.197294f, -40.977509f, -2.107634f, 0.000000f, 1.415778f },
        new[] { 9.193022f, 10.197294f, -40.690060f, -2.082145f, 0.000000f, 1.437238f },
        new[] { 8.782290f, 10.197294f, -40.398022f, -2.053656f, 0.000000f, 1.460193f },
        new[] { 8.378143f, 10.197294f, -40.101349f, -2.020734f, 0.000000f, 1.483373f },
        new[] { 7.981577f, 10.197294f, -39.799294f, -1.982833f, 0.000000f, 1.510276f },
        new[] { 7.592501f, 10.197294f, -39.491383f, -1.945382f, 0.000000f, 1.539564f },
        new[] { 7.235472f, 10.197294f, -39.191612f, -1.785145f, 0.000000f, 1.498847f },
        new[] { 6.856690f, 10.197294f, -38.869774f, -1.893909f, 0.000000f, 1.609192f },
        new[] { 6.501227f, 10.197294f, -38.570526f, -1.777313f, 0.000000f, 1.496231f },
        new[] { 6.224775f, 10.197294f, -38.301174f, -1.382261f, 0.000000f, 1.346764f },
        new[] { 5.929498f, 10.197294f, -37.995701f, -1.476386f, 0.000000f, 1.527363f },
        new[] { 5.629647f, 10.197294f, -37.639618f, -1.499255f, 0.000000f, 1.780412f },
        new[] { 5.328491f, 10.197294f, -37.296764f, -1.505784f, 0.000000f, 1.714271f },
        new[] { 5.023998f, 10.197294f, -36.908840f, -1.522466f, 0.000000f, 1.939620f },
        new[] { 4.744634f, 10.197294f, -36.502831f, -1.396819f, 0.000000f, 2.030053f },
        new[] { 4.492529f, 10.197294f, -36.078068f, -1.260521f, 0.000000f, 2.123809f },
        new[] { 4.239073f, 10.197294f, -35.631050f, -1.267281f, 0.000000f, 2.235098f },
        new[] { 3.989349f, 10.197294f, -35.178169f, -1.248621f, 0.000000f, 2.264413f },
        new[] { 3.736778f, 10.197294f, -34.723938f, -1.262857f, 0.000000f, 2.271152f },
        new[] { 3.491473f, 10.197294f, -34.264828f, -1.226526f, 0.000000f, 2.295557f },
        new[] { 3.177553f, 10.197294f, -33.848518f, -1.569597f, 0.000000f, 2.081553f },
        new[] { 2.866278f, 10.197294f, -33.427658f, -1.556375f, 0.000000f, 2.104302f },
        new[] { 2.566121f, 10.197294f, -32.995960f, -1.500786f, 0.000000f, 2.158491f },
        new[] { 2.291139f, 10.197294f, -32.544334f, -1.374910f, 0.000000f, 2.258132f },
        new[] { 2.066509f, 10.197294f, -32.063156f, -1.123153f, 0.000000f, 2.405891f },
        new[] { 1.949471f, 10.197294f, -31.544592f, -0.585186f, 0.000000f, 2.592823f },
        new[] { 1.841830f, 10.197294f, -31.020411f, -0.538206f, 0.000000f, 2.620903f },
        new[] { 1.804908f, 10.197294f, -30.484823f, -0.184613f, 0.000000f, 2.677938f },
        new[] { 1.848811f, 10.197294f, -29.937574f, 0.219515f, 0.000000f, 2.736246f },
        new[] { 1.946300f, 10.197294f, -29.417610f, 0.487449f, 0.000000f, 2.599819f },
        new[] { 2.111085f, 10.197294f, -28.884066f, 0.823926f, 0.000000f, 2.667721f },
        new[] { 2.288109f, 10.197294f, -28.358007f, 0.885119f, 0.000000f, 2.630293f },
        new[] { 2.499196f, 10.197294f, -27.812208f, 1.055435f, 0.000000f, 2.728995f },
        new[] { 2.709832f, 10.197294f, -27.265604f, 1.053180f, 0.000000f, 2.733017f },
        new[] { 2.920712f, 10.197294f, -26.718000f, 1.054401f, 0.000000f, 2.738015f },
        new[] { 3.166102f, 10.197294f, -26.183590f, 1.226950f, 0.000000f, 2.672051f },
        new[] { 3.409404f, 10.197294f, -25.647873f, 1.216508f, 0.000000f, 2.678585f },
        new[] { 3.604466f, 10.197294f, -25.169361f, 0.975311f, 0.000000f, 2.392557f },
        new[] { 3.799465f, 10.197294f, -24.688942f, 0.974994f, 0.000000f, 2.402100f },
        new[] { 4.008917f, 10.197294f, -24.179743f, 1.047259f, 0.000000f, 2.545998f },
        new[] { 4.254181f, 10.197294f, -23.667099f, 1.226322f, 0.000000f, 2.563215f },
        new[] { 4.411407f, 10.197294f, -23.188858f, 0.786131f, 0.000000f, 2.391205f },
        new[] { 4.630627f, 10.197294f, -22.706358f, 1.096096f, 0.000000f, 2.412497f },
        new[] { 4.733336f, 10.197294f, -22.348816f, 0.513548f, 0.000000f, 1.787710f },
        new[] { 4.886934f, 10.197294f, -22.007650f, 0.767987f, 0.000000f, 1.705831f },
        new[] { 4.930230f, 10.197294f, -21.656166f, 0.216483f, 0.000000f, 1.757425f },
        new[] { 5.044151f, 10.197294f, -21.343338f, 0.569606f, 0.000000f, 1.564138f },
        new[] { 5.169365f, 10.197294f, -21.074562f, 0.626069f, 0.000000f, 1.343884f },
        new[] { 5.241940f, 10.197294f, -20.714607f, 0.362874f, 0.000000f, 1.799778f },
        new[] { 5.323618f, 10.197294f, -20.576834f, 0.408392f, 0.000000f, 0.688868f },
        new[] { 5.316272f, 10.197294f, -20.384502f, -0.036732f, 0.000000f, 0.961652f },
        new[] { 5.301373f, 10.197294f, -20.182859f, -0.074500f, 0.000000f, 1.008217f },
        new[] { 5.295803f, 10.197294f, -19.982578f, -0.027847f, 0.000000f, 1.001405f },
        new[] { 5.286469f, 10.197294f, -19.742945f, -0.046671f, 0.000000f, 1.198163f },
        new[] { 5.275438f, 10.197294f, -19.603636f, -0.055155f, 0.000000f, 0.696540f },
        new[] { 5.288567f, 10.197294f, -19.521788f, 0.065643f, 0.000000f, 0.409236f },
        new[] { 5.440337f, 10.197294f, -19.479048f, 0.758851f, 0.000000f, 0.213696f },
        new[] { 5.633360f, 10.197294f, -19.464310f, 0.965118f, 0.000000f, 0.073694f },
        new[] { 5.825089f, 10.197294f, -19.461432f, 0.958646f, 0.000000f, 0.014389f },
        new[] { 5.962496f, 10.197294f, -19.404169f, 0.687035f, 0.000000f, 0.286309f },
        new[] { 6.051316f, 10.197294f, -19.417604f, 0.444099f, 0.000000f, -0.067175f },
        new[] { 6.134418f, 10.197294f, -19.466887f, 0.415510f, 0.000000f, -0.246414f },
        new[] { 6.195343f, 10.197294f, -19.520611f, 0.304628f, 0.000000f, -0.268624f },
        new[] { 6.233473f, 10.197294f, -19.589584f, 0.190648f, 0.000000f, -0.344869f },
        new[] { 6.143032f, 10.197294f, -19.644495f, -0.452208f, 0.000000f, -0.274552f },
        new[] { 6.066758f, 10.197294f, -19.669443f, -0.381368f, 0.000000f, -0.124736f },
        new[] { 5.988646f, 10.197294f, -19.691917f, -0.390560f, 0.000000f, -0.112371f },
        new[] { 5.880603f, 10.197294f, -19.641851f, -0.540214f, 0.000000f, 0.250327f },
        new[] { 5.768869f, 10.197294f, -19.553535f, -0.558670f, 0.000000f, 0.441585f },
        new[] { 5.773450f, 10.197294f, -19.545095f, 0.022906f, 0.000000f, 0.042200f },
        new[] { 5.764818f, 10.197294f, -19.506109f, -0.043161f, 0.000000f, 0.194928f },
        new[] { 5.769928f, 10.197294f, -19.497072f, 0.025550f, 0.000000f, 0.045183f },
        new[] { 5.753877f, 10.197294f, -19.524942f, -0.080258f, 0.000000f, -0.139354f },
        new[] { 5.731219f, 10.197294f, -19.533819f, -0.113286f, 0.000000f, -0.044384f }
    };

    static readonly float[][] EXPECTED_A1Q2T =
    {
        new[] { 22.990597f, 10.197294f, -46.112606f, -2.999564f, 0.000000f, 1.803501f },
        new[] { 22.524744f, 10.197294f, -45.867702f, -2.989815f, 0.000000f, 1.819617f },
        new[] { 21.946421f, 10.197294f, -45.530769f, -2.987121f, 0.000000f, 1.824035f },
        new[] { 21.357445f, 10.197294f, -45.183083f, -2.985955f, 0.000000f, 1.825945f },
        new[] { 20.766855f, 10.197294f, -44.833454f, -2.985027f, 0.000000f, 1.827461f },
        new[] { 20.176287f, 10.197294f, -44.483444f, -2.984109f, 0.000000f, 1.828960f },
        new[] { 19.586048f, 10.197294f, -44.133289f, -2.983157f, 0.000000f, 1.830513f },
        new[] { 18.996214f, 10.197294f, -43.783005f, -2.982163f, 0.000000f, 1.832130f },
        new[] { 18.406816f, 10.197294f, -43.432552f, -2.981127f, 0.000000f, 1.833817f },
        new[] { 17.817883f, 10.197294f, -43.081890f, -2.980047f, 0.000000f, 1.835571f },
        new[] { 17.229431f, 10.197294f, -42.730961f, -2.978924f, 0.000000f, 1.837393f },
        new[] { 16.641487f, 10.197294f, -42.379704f, -2.977759f, 0.000000f, 1.839280f },
        new[] { 16.054066f, 10.197294f, -42.028053f, -2.976555f, 0.000000f, 1.841228f },
        new[] { 15.467182f, 10.197294f, -41.675930f, -2.975313f, 0.000000f, 1.843233f },
        new[] { 14.880149f, 10.197294f, -41.325222f, -2.974040f, 0.000000f, 1.845288f },
        new[] { 14.292006f, 10.197294f, -40.972252f, -2.972459f, 0.000000f, 1.847835f },
        new[] { 13.702817f, 10.197294f, -40.616268f, -2.970898f, 0.000000f, 1.850342f },
        new[] { 13.113760f, 10.197294f, -40.258976f, -2.969465f, 0.000000f, 1.852640f },
        new[] { 12.525526f, 10.197294f, -39.902176f, -2.968050f, 0.000000f, 1.854907f },
        new[] { 11.938206f, 10.197294f, -39.545849f, -2.966453f, 0.000000f, 1.857459f },
        new[] { 11.351962f, 10.197294f, -39.190098f, -2.964650f, 0.000000f, 1.860337f },
        new[] { 10.767020f, 10.197294f, -38.835106f, -2.962592f, 0.000000f, 1.863611f },
        new[] { 10.183690f, 10.197294f, -38.481129f, -2.960215f, 0.000000f, 1.867385f },
        new[] { 9.602149f, 10.197294f, -38.128098f, -2.957422f, 0.000000f, 1.871805f },
        new[] { 9.023255f, 10.197294f, -37.777180f, -2.954136f, 0.000000f, 1.876987f },
        new[] { 8.448158f, 10.197294f, -37.429573f, -2.950055f, 0.000000f, 1.883394f },
        new[] { 7.879329f, 10.197294f, -37.087776f, -2.944782f, 0.000000f, 1.891628f },
        new[] { 7.319548f, 10.197294f, -36.753658f, -2.937588f, 0.000000f, 1.902782f },
        new[] { 6.776391f, 10.197294f, -36.434063f, -2.927629f, 0.000000f, 1.918068f },
        new[] { 6.269217f, 10.197294f, -36.142403f, -2.912834f, 0.000000f, 1.940462f },
        new[] { 5.846630f, 10.197294f, -35.881496f, -2.890513f, 0.000000f, 1.973559f },
        new[] { 5.411777f, 10.197294f, -35.547710f, -2.874764f, 0.000000f, 1.996430f },
        new[] { 4.896369f, 10.197294f, -35.184120f, -2.896978f, 0.000000f, 1.964057f },
        new[] { 4.367188f, 10.197294f, -34.833569f, -2.910470f, 0.000000f, 1.944008f },
        new[] { 3.807542f, 10.197294f, -34.472218f, -2.906039f, 0.000000f, 1.950624f },
        new[] { 3.238266f, 10.197294f, -34.064877f, -2.846376f, 0.000000f, 2.036700f },
        new[] { 2.917057f, 10.197294f, -33.455391f, -1.420109f, 0.000000f, 3.198952f },
        new[] { 2.645415f, 10.197294f, -32.810249f, -1.358214f, 0.000000f, 3.225718f },
        new[] { 2.373772f, 10.197294f, -32.165104f, -1.358212f, 0.000000f, 3.225718f },
        new[] { 2.103753f, 10.197294f, -31.530035f, -1.358215f, 0.000000f, 3.225717f },
        new[] { 1.837103f, 10.197294f, -30.882812f, -1.333248f, 0.000000f, 3.236116f },
        new[] { 1.887709f, 10.197294f, -30.193766f, 0.449056f, 0.000000f, 3.471073f },
        new[] { 2.034543f, 10.197294f, -29.509338f, 0.734173f, 0.000000f, 3.422132f },
        new[] { 2.266320f, 10.197294f, -28.848824f, 1.158885f, 0.000000f, 3.302572f },
        new[] { 2.498098f, 10.197294f, -28.188309f, 1.158885f, 0.000000f, 3.302572f },
        new[] { 2.729875f, 10.197294f, -27.527794f, 1.158886f, 0.000000f, 3.302572f },
        new[] { 2.992905f, 10.197294f, -26.879091f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 3.255934f, 10.197294f, -26.230389f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 3.518964f, 10.197294f, -25.581686f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 3.781994f, 10.197294f, -24.932983f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 4.045024f, 10.197294f, -24.284281f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 4.308054f, 10.197294f, -23.635578f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 4.571084f, 10.197294f, -22.986876f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 4.834114f, 10.197294f, -22.338173f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 5.097065f, 10.197294f, -21.689661f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 5.349040f, 10.197294f, -21.068123f, 1.315149f, 0.000000f, 3.243514f },
        new[] { 5.564819f, 10.197294f, -20.535385f, 1.315191f, 0.000000f, 3.243497f },
        new[] { 5.742907f, 10.197294f, -20.094234f, 1.315492f, 0.000000f, 3.243375f },
        new[] { 5.844197f, 10.197294f, -19.830488f, 1.316821f, 0.000000f, 3.242836f },
        new[] { 5.890507f, 10.197294f, -19.651239f, 1.327608f, 0.000000f, 3.238434f },
        new[] { 5.895338f, 10.197294f, -19.433264f, 1.384180f, 0.000000f, 3.214661f },
        new[] { 5.917773f, 10.197294f, -19.188416f, 1.594034f, 0.000000f, 3.115936f },
        new[] { 5.947361f, 10.197294f, -19.047245f, 1.574677f, 0.000000f, 2.491868f },
        new[] { 5.960892f, 10.197294f, -18.990824f, 1.488381f, 0.000000f, 2.080121f },
        new[] { 5.971087f, 10.197294f, -18.963556f, 1.448915f, 0.000000f, 1.915559f },
        new[] { 5.977089f, 10.197294f, -18.950905f, 1.419177f, 0.000000f, 1.836029f }
    };

    [Test]
    public void TestAgent1Quality2TVTA()
    {
        int updateFlags = DtCrowdAgentUpdateFlags.DT_CROWD_ANTICIPATE_TURNS |
                          DtCrowdAgentUpdateFlags.DT_CROWD_OPTIMIZE_VIS |
                          DtCrowdAgentUpdateFlags.DT_CROWD_OPTIMIZE_TOPO | 
                          DtCrowdAgentUpdateFlags.DT_CROWD_OBSTACLE_AVOIDANCE;

        AddAgentGrid(2, 0.3f, updateFlags, 2, startPoss[0]);
        SetMoveTarget(endPoss[0], false);
        for (int i = 0; i < EXPECTED_A1Q2TVTA.Length; i++)
        {
            crowd.Update(1 / 5f, null);
            DtCrowdAgent ag = agents[2];
            Assert.That(ag.npos.X, Is.EqualTo(EXPECTED_A1Q2TVTA[i][0]).Within(0.001f), $"{i}");
            Assert.That(ag.npos.Y, Is.EqualTo(EXPECTED_A1Q2TVTA[i][1]).Within(0.001f), $"{i}");
            Assert.That(ag.npos.Z, Is.EqualTo(EXPECTED_A1Q2TVTA[i][2]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.X, Is.EqualTo(EXPECTED_A1Q2TVTA[i][3]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.Y, Is.EqualTo(EXPECTED_A1Q2TVTA[i][4]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.Z, Is.EqualTo(EXPECTED_A1Q2TVTA[i][5]).Within(0.001f), $"{i}");
        }
    }

    [Test]
    public void TestAgent1Quality2TVTAS()
    {
        int updateFlags = DtCrowdAgentUpdateFlags.DT_CROWD_ANTICIPATE_TURNS | 
                          DtCrowdAgentUpdateFlags.DT_CROWD_OPTIMIZE_VIS | 
                          DtCrowdAgentUpdateFlags.DT_CROWD_OPTIMIZE_TOPO | 
                          DtCrowdAgentUpdateFlags.DT_CROWD_OBSTACLE_AVOIDANCE | 
                          DtCrowdAgentUpdateFlags.DT_CROWD_SEPARATION;

        AddAgentGrid(2, 0.3f, updateFlags, 2, startPoss[0]);
        SetMoveTarget(endPoss[0], false);
        for (int i = 0; i < EXPECTED_A1Q2TVTAS.Length; i++)
        {
            crowd.Update(1 / 5f, null);
            DtCrowdAgent ag = agents[2];
            Assert.That(ag.npos.X, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][0]).Within(0.001f), $"{i}");
            Assert.That(ag.npos.Y, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][1]).Within(0.001f), $"{i}");
            Assert.That(ag.npos.Z, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][2]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.X, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][3]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.Y, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][4]).Within(0.001f), $"{i}");
            Assert.That(ag.nvel.Z, Is.EqualTo(EXPECTED_A1Q2TVTAS[i][5]).Within(0.001f), $"{i}");
        }
    }

    [Test]
    public void TestAgent1Quality2T()
    {
        int updateFlags = DtCrowdAgentUpdateFlags.DT_CROWD_OPTIMIZE_TOPO;

        AddAgentGrid(2, 0.3f, updateFlags, 2, startPoss[0]);
        SetMoveTarget(endPoss[0], false);
        for (int i = 0; i < EXPECTED_A1Q2T.Length; i++)
        {
            crowd.Update(1 / 5f, null);
            DtCrowdAgent ag = agents[2];
            Assert.That(ag.npos.X, Is.EqualTo(EXPECTED_A1Q2T[i][0]).Within(0.00001f), $"{i} - {ag.npos.X} {EXPECTED_A1Q2T[i][0]}");
            Assert.That(ag.npos.Y, Is.EqualTo(EXPECTED_A1Q2T[i][1]).Within(0.00001f), $"{i} - {ag.npos.Y} {EXPECTED_A1Q2T[i][1]}");
            Assert.That(ag.npos.Z, Is.EqualTo(EXPECTED_A1Q2T[i][2]).Within(0.00001f), $"{i} - {ag.npos.Z} {EXPECTED_A1Q2T[i][2]}");
            Assert.That(ag.nvel.X, Is.EqualTo(EXPECTED_A1Q2T[i][3]).Within(0.00001f), $"{i} - {ag.nvel.X} {EXPECTED_A1Q2T[i][3]}");
            Assert.That(ag.nvel.Y, Is.EqualTo(EXPECTED_A1Q2T[i][4]).Within(0.00001f), $"{i} - {ag.nvel.Y} {EXPECTED_A1Q2T[i][4]}");
            Assert.That(ag.nvel.Z, Is.EqualTo(EXPECTED_A1Q2T[i][5]).Within(0.00001f), $"{i} - {ag.nvel.Z} {EXPECTED_A1Q2T[i][5]}");
        }
    }
}