/**
 * Created by ADMIN on 28.1.2017 г..
 */
function extractLinks(sentences){

    let result=[];

    let pattern=/www\.([a-zA-Z0-9-])+(\.[a-z]+)+/g;

    for(let item of sentences){

        let match=pattern.exec(item);

        while(match){
            result.push(match[0]);
            match=pattern.exec();
        }
    }

    console.log(result.join('\n'));

}

//extractLinks(['Join WebStars now for free, at www.web-stars.com','You can also support our partners:'])