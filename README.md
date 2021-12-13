# URP Lit shader with glittering effect

Inspired by GDC talk [Sand Rendering in Journey].

## Add glittering effect on top of the object surface. 
<img height="200" alt="result" src="https://user-images.githubusercontent.com/13420668/145828189-0b106ab0-02a5-44f4-8ab3-f01f1a4e26a1.png"> <img height="200" alt="result" src="https://user-images.githubusercontent.com/13420668/145828126-fd186dcd-2179-4df4-81b8-3773c3805780.png">
<img height="200" alt="result" src="https://user-images.githubusercontent.com/13420668/145829125-b8f8b1d6-8345-48f0-a041-188dd35e4bd5.png">

## How To USE

Toggle the **Enable Glitter** option in the material inspector

![image](https://user-images.githubusercontent.com/13420668/145830091-d27df57e-eade-408e-bd60-83d9985f5b5f.png)

Put your own noise texture into the **glitter noise map** property.
Messing around the GlitterSize and GlitterGlossness properties.

### Theirs 2 methods through toggle **_UseLightDirection** option: 

 - **_UseLightDirection** enable : A specular glitter based on NdotH.
 - **_UseLightDirection** disable : A specular glitter based NdotV only (which is the one Journey use).

![image](https://user-images.githubusercontent.com/13420668/145827593-3d176b8e-7ccc-426e-ab96-10875d5d233c.png)

Since the shader is mostly stripped from official [Lit.shader]. feel free to put your own lighting logic inside [CustomLitForwardPass.hlsl]

## DEMO

https://user-images.githubusercontent.com/13420668/145831085-82966847-c907-438f-9d41-9ecdb7e4a57a.mp4



[Sand Rendering in Journey]: https://www.youtube.com/watch?v=wt2yYnBRD3U

[Lit.shader]: https://github.com/Unity-Technologies/Graphics/blob/master/com.unity.render-pipelines.universal/Shaders/Lit.shader
[CustomLitForwardPass.hlsl]: https://github.com/EricHu33/URP_GlitterLit/blob/main/Assets/Scripts/Shaders/Library/CustomLitForwardPass.hlsl
