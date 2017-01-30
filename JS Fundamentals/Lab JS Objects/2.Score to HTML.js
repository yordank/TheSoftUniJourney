/**
 * Created by ADMIN on 30.1.2017 г..
 */
function scoreToHTMLTable([scoreJSON]) {
    let html = "<table>\n";

    html += "  <tr><th>name</th><th>score</th></tr>\n";

    let arr = JSON.parse(scoreJSON);

    for (let obj of arr)
        html += `  <tr><td>${htmlEscape(obj['name'])}` +
            `</td><td>${obj['score']}</td></tr>\n`;
    return html + "</table>";

    function htmlEscape(text) {

        text=text.replace(/&/g,'&amp;');
        text=text.replace(/</g,'&lt;');
        text=text.replace(/>/g,'&gt;');
        text=text.replace(/"/g,'&quot;');
        text=text.replace(/'/g,'&#39;');
        return text;
    }
}


//console.log(scoreToHTMLTable(['[{"name":"Pesho","score":70}]']))
