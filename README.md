# OrakTech.Inputs
## Focusable Inputs
Adds FocusAsync Support `EditForm` inputs.

### Inputs Supported

 - FInputText 
 - FInputTextArea 
 - FInputNumber<TValue> 
 - FInputDate<TValue> 
 - FInputSelect<TValue> 


### Usage


```
@using OrakTech.Inputs.Components

<FInputText @ref="fInputText" @bind-Value="@...  />

<button @onclick="@(()=>fInputText.FocusAsync())">Focus</button>
```