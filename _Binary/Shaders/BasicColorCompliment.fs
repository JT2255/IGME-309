#version 330

in vec3 Color;

uniform vec3 SolidColor = vec3(-1,-1,-1);
uniform bool ComplimentaryColor = false;

out vec4 Fragment;

void main()
{
	vec3 color = Color;
	Fragment = vec4(Color,1);
	
	if(SolidColor.r != -1.0 && SolidColor.g != -1.0 && SolidColor.b != -1.0)
		color=SolidColor;


	if (ComplimentaryColor)
	{
		color = vec3(1.0f, 1.0f, 1.0f) - color;		
	}
	Fragment = vec4(color, 1);
	return;
}