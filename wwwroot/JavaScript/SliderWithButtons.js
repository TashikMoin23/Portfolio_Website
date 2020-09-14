var slider_content = document.getElementById('box');

// contain images in an array
var image = ['/Img/Home-background-1', '/Img/Home-background-2', '/Img/Home-background-3', '/Img/Home-background-4', '/Img/Home-background-5'];

var i = image.length;


// function for next slide 

function nextImage()
{
    if (i < image.length)
    {
        i = i + 1;
    }
    else
    {
        i = 1;
    }
    slider_content.innerHTML = "<img src=" + image[i - 1] + ".jpg>";
}


// function for prev slide

function prevImage()
{

    if (i < image.length + 1 && i > 1)
    {
        i = i - 1;
    }
    else
    {
        i = image.length;
    }
    slider_content.innerHTML = "<img src=" + image[i - 1] + ".jpg>";

}


// script for auto image slider

setInterval(nextImage, 4000);