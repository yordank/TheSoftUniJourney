/**
 * Created by ADMIN on 21.1.2017 г..
 */
function PointInRect([x, y, xMin, xMax, yMin, yMax ]){

    [x, y, xMin, xMax, yMin, yMax ]=[x, y, xMin, xMax, yMin, yMax ].map(Number);
    if(x<=xMax && x>= xMin && y<=yMax && y>=yMin )
    {
        console.log('inside')
    }

    else
    {
        console.log('outside');
    }

}

