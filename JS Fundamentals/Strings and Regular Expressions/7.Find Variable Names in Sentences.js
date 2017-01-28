/**
 * Created by ADMIN on 28.1.2017 г..
 */
function findVariableNames([text]){

    let pattern=/\b_([a-zA-Z0-9]+)\b/g;
    let result=[];
    let match=pattern.exec(text);

    while(match){
        result.push(match[1]);
        match=pattern.exec(text);
    }
    console.log(result.join(','))

}
//findVariableNames(['The _id and _age variables are both integers.'])