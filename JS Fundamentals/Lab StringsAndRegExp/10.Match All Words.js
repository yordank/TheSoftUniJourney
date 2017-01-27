/**
 * Created by ADMIN on 27.1.2017 г..
 */
function matchAllWords([input]){

    let result=input.split(/[\W()]/g);

    console.log(result.filter(x=>x.length>0).join('|'))

}
//matchAllWords(['A Regular Expression needs to have the global flag in order to match all occurrences in the text'])
//matchAllWords(['_(Underscores) are also word characters'])