/**
 * Created by ADMIN on 24.1.2017 г..
 */
function maxCombination([num1,num2,count]){

    [num1,num2,count]=[num1,num2,count].map(Number);

    let line='';

    let steps=1;

    for(let i=num1;i<=num2;i++)
    {
        for(let j=num1;j<=num2;j++)
        {
            if(steps<=count)
            line+=`<${i}-${j}>`;
            else
                break;

            steps++;
        }
    }

    console.log(line);

}


//maxCombination(['1','4','5'])
//maxCombination(['69','71','100'])
//maxCombination(['45','120','20'])