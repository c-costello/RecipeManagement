var ingCounter = 0;
$('.ingredient-adder').on('click', () => {
    ingCounter++;
    console.log(ingCounter);
    $(`<input type = "text" id = "Ingredients_${ingCounter}__Quantity" name = "Ingredients[${ingCounter}].Quantity" value = "" >\n <input type="text" id="Ingredients_${ingCounter}__Name" name="Ingredients[${ingCounter}].Name" value=""> \n<input type="text" id="Ingredients_${ingCounter}__Notes" name="Ingredients[${ingCounter}].Notes" value="">`).appendTo('.ingredients')
})