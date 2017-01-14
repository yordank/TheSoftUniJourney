/**
 * Created by ADMIN on 14.1.2017 г..
 */

function FigureArea([side1,side2,side3,side4]){

    return side1*side2+side3*side4-Math.min(side1,side3)*Math.min(side2,side4);
}

