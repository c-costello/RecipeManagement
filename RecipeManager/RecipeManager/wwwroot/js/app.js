﻿var ingCounter = $('.final-ing-count').text()
var instCounter = $('.final-inst-count').text()
$('.ingredient-adder').on('click', () => {
    ingCounter++;
    console.log(ingCounter);
    $(`<tr class='test'> \n <td> \n <input type = "text" id = "Ingredients_${ingCounter}__Quantity" name = "Ingredients[${ingCounter}].Quantity" value = "" > \n </td>\n <td> <input type="text" id="Ingredients_${ingCounter}__Name" name="Ingredients[${ingCounter}].Name" value=""> \n </td> \n <td> \n <input type="text" id="Ingredients_${ingCounter}__Notes" name="Ingredients[${ingCounter}].Notes" value=""> \n </td> \n </tr>`).appendTo('.ingredients');

})

$('.instruction-adder').on('click', () => {
    instCounter++;
    console.log(instCounter);
    $(`<tr>\n<td>\n <input type="text" id="Instructions_${instCounter}__StepNumber" name="Instructions[${instCounter}].StepNumber" value = "${instCounter + 1}" >\n</td>\n<td> \n <input type = "text" id = "Instructions_${instCounter}__Detail" name = "Instructions[${instCounter}].Detail" value = "" >\n</td>\n</tr>`).appendTo('.instructions')
})

   