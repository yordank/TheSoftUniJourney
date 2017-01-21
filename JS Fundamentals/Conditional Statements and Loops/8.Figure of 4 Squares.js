/**
 * Created by ADMIN on 21.1.2017 г..
 */
function figureOf4Squares([num]){


    num=Number(num);

    if(num==2)
    {
        console.log('+');
        return;
    }

    let firstLine="+";



    firstLine+='-'.repeat(num-2);



    firstLine+='+';



    firstLine+='-'.repeat(num-2);


    firstLine+="+";

    console.log(firstLine);

    let row='|';

    row+=' '.repeat(num-2);
    row+='|';

    row+=' '.repeat(num-2);
    row+='|';



    if(num%2==0){
        for(let i=0;i<(num-1-3)/2;i++)
            console.log(row);
        console.log(firstLine);

        for(let i=0;i<(num-1-3)/2;i++)
            console.log(row);

        console.log(firstLine);
    }
    else{
        for(let i=0;i<(num-1-2)/2;i++)
            console.log(row);
        console.log(firstLine);

        for(let i=0;i<(num-1-2)/2;i++)
            console.log(row);

        console.log(firstLine);

    }


}

figureOf4Squares(['2']);

