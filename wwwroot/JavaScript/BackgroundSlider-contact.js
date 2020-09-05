var Counter = 0;
var Total_Images = [];
var Time = 4000;

Total_Images[0] = '/Img/home-background-1.jpg' ;
Total_Images[1] = '/Img/home-background-2.jpg' ;
Total_Images[2] = '/Img/home-background-3.jpg';
Total_Images[3] = '/Img/home-background-4.jpg';



function Change_Slide()
{
    document.querySelector("#showcase-contact").style.backgroundImage = `url(${Total_Images[Counter]})`;
    if (Counter < Total_Images.length - 1)
    {
        Counter++;
    }
    else
    {
        Counter = 0;
    }

    setTimeout(Change_Slide, Time);
}
Change_Slide();