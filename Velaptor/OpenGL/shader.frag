﻿/*Info:
This is an example of alpha blending.

Src: https://stackoverflow.com/questions/746899/how-to-calculate-an-rgb-colour-by-specifying-an-alpha-blending-amount
*/
#version 450 core

in vec2 v_TexCoord;
in vec4 v_TintClr;

out vec4 o_OutputColor;

uniform sampler2D texture0;//For regular texture rendering


void main ()
{
	o_OutputColor = texture(texture0, v_TexCoord) * v_TintClr;
}