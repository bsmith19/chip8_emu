#version 460 core

uniform mat4 projectionMatrix;

in vec3 in_position;
in vec4 in_color;
out vec4 ex_color;

void main(void)
{
    gl_position = projectionMatrix * vec4(in_position, 1.0);
    ex_color = in_color;
}