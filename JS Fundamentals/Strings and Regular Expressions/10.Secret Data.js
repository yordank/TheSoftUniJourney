/**
 * Created by ADMIN on 28.1.2017 г..
 */
function secretData(sentences){



        let patternName = /\*[A-Z][A-Za-z]*(?=\s|$)/g
        let patternPhone = /\+[0-9-]{10}(?=\s|$)/g
        let patternId = /![a-zA-Z0-9]+(?=\s|\t|$)/g
        let patternBase = /_[0-9A-Za-z]+(?=\s|$)/g

        for (let sentence of sentences) {
            console.log(sentence
                .replace(patternName, m => '|'.repeat(m.length))
                .replace(patternPhone, m => '|'.repeat(m.length))
                .replace(patternId, m => '|'.repeat(m.length))
                .replace(patternBase, m => '|'.repeat(m.length))
            )
        }


}
//secretData(['Agent ,*Ivankov    was in the room when it all happened. *I  I think it was +555-49-796 ','**'])