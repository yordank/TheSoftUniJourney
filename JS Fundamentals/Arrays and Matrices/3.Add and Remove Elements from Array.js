/**
 * Created by ADMIN on 26.1.2017 г..
 */
function addAndRemoveElements(input){

    let result=[];
    let current=1;
    for(let item of input){
        if(item=='add'){
            result.push(current);
            current++;
        }
        if(item=='remove'){
            result.pop();
            current++;
        }

    }

    if(result.length>0)
        console.log(result.join('\n'));
    else
        console.log('Empty');

}
//addAndRemoveElements(['add','add','remove','add','add'])
//addAndRemoveElements(['remove'])