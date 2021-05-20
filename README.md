# Scaling test WPF C# Application

This C# WPF app demonstrates the ability to change the scaling of the parent window through the child modal window.  
This project is my homework assigment (2021 year).

```csharp
// Default height and width of the parent window.
private const uint DefaultHeight = 300;
private const uint DefaultWidth = 500;
```

```csharp
// scaling - scaling unsigned int value.
public void ChangeScaling(uint scaling)
{
    Height = DefaultHeight * scaling / 100;
    Width = DefaultWidth * scaling / 100;
}
```

The parent window with the "change scaling" button.  
![](https://i.ibb.co/SwhjZLF/1.png)

The result of changing the scaling of the parent window by clicking the "apply" button in the modal window.  
![](https://i.ibb.co/qRqg4fL/2.png)
