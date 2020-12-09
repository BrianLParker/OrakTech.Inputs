# OrakTech.Inputs

[![NuGet](https://img.shields.io/badge/NuGet-version%3A%201.0.0.8-blue)](https://www.nuget.org/packages/OrakTech.Inputs/)

## Focusable Inputs
Adds FocusAsync Support `EditForm` inputs.

### Inputs Supported

 - FInputText 
 - FInputTextArea 
 - FInputNumber<TValue> 
 - FInputDate<TValue> 
 - FInputSelect<TValue> 
 - FInputEnum<TValue>

`_Imports.razor`
```
@using OrakTech.Inputs.Components
```

### Usage
```
<FInputText @ref="fInputText" @bind-Value="@...  />

<button @onclick="@(()=>fInputText.FocusAsync())">Focus</button>
```

### Set focus on component render.

```
protected override async Task OnAfterRenderAsync(bool firstRender)
{
    if (firstRender)
    {
        await fInputText.FocusAsync();
    }
}
```


`FInputEnum`
```
<FInputEnum @ref="fInputEnum" @bind-Value="@someModel.Day" />
```

or

```
<FInputEnum Context="day" @ref="fInputEnum" @bind-Value="@someModel.Day"  >
    <option value="@day"> === @day === </option>
</FInputEnum>
```

Note: Context="day" prevents a conflict with the `EditForms` "Context" name. Alternately you could rename the `EditForms` context.

```
<EditForm Context="someOtherName" ...
``` 