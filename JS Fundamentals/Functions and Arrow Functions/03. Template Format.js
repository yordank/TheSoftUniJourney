/**
 * Created by ADMIN on 25.1.2017 г..
 */
function templateFormat(input){

   let output='<?xml version="1.0" encoding="UTF-8"?>\n';
       output+='<quiz>\n';


    for(let i=0;i<input.length;i=i+2){

       output+= questionAnswer(input[i],input[i+1]);
    }

    function questionAnswer(question,answer){

        let str='   <question>\n';
        str+='      '+question+'\n';
        str+='  </question>\n';
        str+='  <answer>\n';
        str+='      '+answer+'\n';
        str+='  </answer>\n';

        return str;
    }

    output+='</quiz>';
    console.log(output);
}

//templateFormat(['1','test','2','BOTEV'])