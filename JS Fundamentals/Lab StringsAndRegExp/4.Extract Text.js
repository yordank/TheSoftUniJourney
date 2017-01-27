/**
 * Created by ADMIN on 27.1.2017 г..
 */
function extractText([input]){

    let result=[];

    let pattern=/\((.*?)\)/g;
    let match;
    while (match = pattern .exec(input))
     result.push(match[1]);

    console.log(result.join(', '))
}

//extractText(['(test)Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)'])