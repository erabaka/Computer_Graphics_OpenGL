#version 330 core
out vec4 FragColor;
out vec4 FragColor2;

in vec3 ourColor;
in vec3 ourColor2;
void main()
{
    FragColor = vec4(ourColor, 1.0f);
    FragColor2 = vec4(ourColor2, 1.0f);
}