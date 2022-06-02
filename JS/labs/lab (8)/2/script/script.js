var flag = true;
function bm(evt)
{
    var e =  evt || window.event;
    var elem = e.target || e.srcElement;
    var id1 = elem.id;
    var z1 = document.getElementById("img")
    var z2 = document.getElementById("pi")
    if(id1 == "img")
    {
        if(flag)
        {
            z1.src = "img2.jpg";
            z2.textContent = "img2.jpg";
            flag = false;
        }else{
            z1.src = "img1.png";
            z2.textContent = "img1.png";
            flag = true;
        }
    }else if(id1 == "pi"){
        if(z2.style.color == "black")
        z2.style.color = "red";
        else 
        z2.style.color = "black";
    }
}