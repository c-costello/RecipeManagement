var ingCounter = 0;
var instCounter = 0;
$('.ingredient-adder').on('click', () => {
    ingCounter++;
    console.log(ingCounter);
    $(`<input type = "text" id = "Ingredients_${ingCounter}__Quantity" name = "Ingredients[${ingCounter}].Quantity" value = "" >\n <input type="text" id="Ingredients_${ingCounter}__Name" name="Ingredients[${ingCounter}].Name" value=""> \n<input type="text" id="Ingredients_${ingCounter}__Notes" name="Ingredients[${ingCounter}].Notes" value="">`).appendTo('.ingredients')
})

$('.instruction-adder').on('click', () => {
    instCounter++;
    console.log(instCounter);
    $(`<input type = "text" id = "Instructions_${instCounter}__Detail" name = "Instructions[${instCounter}].Detail" value = "" >\n <input type="text" id="Instructions_${instCounter}__StepNumber" name="Instructions[${instCounter}].StepNumber" value="${instCounter + 1}">`).appendTo('.instructions')
})