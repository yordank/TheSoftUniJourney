/**
 * Created by ADMIN on 19.1.2017 г..
 */
function distance3D([x1,y1,z1,x2,y2,z2]){

    [x1,y1,z1,x2,y2,z2]=[x1,y1,z1,x2,y2,z2].map(Number);

    console.log(Math.sqrt((x1-x2)**2+(y1-y2)**2+(z1-z2)**2));

}
