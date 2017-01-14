/**
 * Created by ADMIN on 14.1.2017 г..
 */
function LetterOccurences([text,letter]){

    let count=0;

    for(let i=0;i<text.length;i++)
    {
        if(text[i]==letter)
            count++;
    }

    console.log(count);
}
