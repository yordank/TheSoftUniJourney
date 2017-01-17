/**
 * Created by ADMIN on 17.1.2017 г..
 */
function chessboard([n]){

console.log(`<div class="chessboard">`);


    for(let i=0;i<n;i++)
    {
        console.log(`    <div>`);
        let flag=i%2;
        for(let j=0;j<n;j++)
        {
            if(flag==0)
            {
                if(j%2==0)
                    console.log(`        <span class="black"></span>`);
                else
                    console.log(`        <span class="white"></span>`);
            }

            else
            {
                if(j%2==0)
                    console.log(`        <span class="white"></span>`);
                else
                    console.log(`        <span class="black"></span>`);
            }

        }
        console.log(`    </div>`);
    }
    console.log(`</div>`);

}

