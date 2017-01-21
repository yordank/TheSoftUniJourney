/**
 * Created by ADMIN on 21.1.2017 г..
 */
function multiplicationTable([n]){

    console.log(`<table border="1">`);

    let line='<tr><th>x</th>';

    for(let i=1;i<=Number(n);i++){
        line+='<th>';
        line+=i;
        line+='</th>';
    }

    line+='</tr>';

    console.log(line);


    for(let row=1;row<=n;row++){

        let line=`<tr><th>${row}</th>`;

        for(let col=1;col<=Number(n);col++){
            line+='<td>';
            line+=row*col;
            line+='</td>';
        }

        line+='</tr>';

        console.log(line);

    }

    console.log(`</table>`);

}

