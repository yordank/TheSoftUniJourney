/**
 * Created by ADMIN on 27.1.2017 г..
 */
function expressionSplit(input) {
    let expression = input[0];
    let elements = expression
        .split(/[\s.();,]+/);
    console.log(elements.join("\n"));
}

expressionSplit(
    ['let sum = 4 * 4,b = "wow";'])
