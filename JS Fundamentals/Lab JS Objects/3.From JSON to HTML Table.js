/**
 * Created by ADMIN on 30.1.2017 г..
 */
function JSONToHTMLTable([json]) {
    let html = "<table>\n";
    let arr = JSON.parse(json);
    html += "  <tr>";
    for (let key of Object.keys(arr[0]))
        html += `<th>${htmlEscape(key)}</th>`;
    html += "</tr>\n";
    for (let obj of arr) {
        // TODO: print obj values in <tr><td>…</td></tr>

     html+=`  <tr>`;

        for (let value of Object.values(obj)) {

            html += `<td>${(isNaN(value)==true)?htmlEscape(value):value}</td>`
        }
     html+=`</tr>\n`;


    }
    function htmlEscape(text) {

        text=text.replace(/&/g,'&amp;');
        text=text.replace(/</g,'&lt;');
        text=text.replace(/>/g,'&gt;');
        text=text.replace(/"/g,'&quot;');
        text=text.replace(/'/g,'&#39;');
        return text;
    }

    return html + "</table>";
}
//console.log(JSONToHTMLTable(['[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]']))