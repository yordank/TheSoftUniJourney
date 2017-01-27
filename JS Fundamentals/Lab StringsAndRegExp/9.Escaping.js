/**
 * Created by ADMIN on 27.1.2017 г..
 */
function escaping(input){

    console.log('<ul>');

        for(let i of input){
            let line='  <li>';

            let output=i.replace(/&/g,'&amp;');
            output=output.replace(/</g,'&lt;');
            output=output.replace(/>/g,'&gt;');

            output=output.replace(/"/g,'&quot;');
            line+=output;
            line+='</li>';
            console.log(line);
        }

    console.log('</ul>');
}

//escaping(['<b>unescaped text</b>', 'normal text'])