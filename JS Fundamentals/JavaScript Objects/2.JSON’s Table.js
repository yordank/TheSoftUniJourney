/**
 * Created by ADMIN on 31.1.2017 г..
 */
function jsonTable(input){

    let output='<table>\n';

    for(let line of input){

        output+='    <tr>\n';

        let obj=JSON.parse(line);

        for(let key of Object.keys(obj)){

            output+=`         <td>${htmlEscape(obj[key])}</td>\n`;
        }


        function htmlEscape(text) {

            if(isNaN(text)) {
                text = text.replace(/&/g, '&amp;');
                text = text.replace(/</g, '&lt;');
                text = text.replace(/>/g, '&gt;');
                text = text.replace(/"/g, '&quot;');
                text = text.replace(/'/g, '&#39;');
                return text;
            }
            else
                return text;
        }

        output+='    <tr>\n';

    }
    output+='</table>';
    console.log(output);


}
/*
jsonTable(
    [
    '{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'
    ]
)
    */