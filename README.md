# OrakTech.Inputs
## Focusable Inputs
Adds FocusAsync Support `EditForm` inputs.
`_Imports.razor`
```
@using OrakTech.Inputs.Components
```

### Inputs Supported

 - FInputText 
 - FInputTextArea 
 - FInputNumber<TValue> 
 - FInputDate<TValue> 
 - FInputSelect<TValue> 

### Usage
```
<FInputText @ref="fInputText" @bind-Value="@...  />

<button @onclick="@(()=>fInputText.FocusAsync())">Focus</button>
```