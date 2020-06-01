
window.onload = function () {
    var screen = document.getElementById("screen");
    var ul = screen.children[0];
    var ol = screen.children[1];
    var div = screen.children[2];
    var imgWidth = screen.offsetWidth;

    //2
    var tempLi = ul.children[0].cloneNode(true);
    ul.appendChild(tempLi);
    //3
    for (var i = 0; i < ul.children.length - 1; i++) {
        var newOlLi = document.createElement("li");
        newOlLi.innerHTML = i + 1;
        ol.appendChild(newOlLi);
    }
    var olLiArr = ol.children;
    olLiArr[0].className = "current";
    //4
    for (var i = 0, len = olLiArr.length; i < len; i++) {
        olLiArr[i].index = i;
        olLiArr[i].onmouseover = function (ev) {
            for (var j = 0; j < len; j++) {
                olLiArr[j].className = "";
            }
            this.className = "current";
            key = square = this.index;
            animate(ul, -this.index * imgWidth);
        }
    }
    //5
    var key = 0;
    var square = 0;
    var timer = setInterval(autoPlay, 3000);
    screen.onmouseover = function (ev) {
        clearInterval(timer);
        div.style.display = "block";
    }
    screen.onmouseout = function (ev) {
        timer = setInterval(autoPlay, 3000);
        div.style.display = "none";
    }
    //6
    var divArr = div.children;
    divArr[0].onclick = function (ev) {
        key--;
        if (key < 0) {
            ul.style.left = -(ul.children.length - 1) * imgWidth + "px";
            key = 4;
        }
        animate(ul, -key * imgWidth);
        square--;
        if (square < 0) {
            square = 4;
        }
        for (var k = 0; k < len; k++) {
            olLiArr[k].className = "";
        }
        olLiArr[square].className = "current";
    }
    divArr[1].onclick = autoPlay;
    function autoPlay() {
        key++;
        //当不满足下面的条件是时候，轮播图到了最后一个孩子，进入条件中后，瞬移到
        //第一张，继续滚动。
        if (key > ul.children.length - 1) {
            ul.style.left = 0;
            key = 1;
        }
        animate(ul, -key * imgWidth);
        square++;
        if (square > 4) {
            square = 0;
        }
        for (var k = 0; k < len; k++) {
            olLiArr[k].className = "";
        }
        olLiArr[square].className = "current";
    }
    function animate(ele, target) {
        clearInterval(ele.timer);
        var speed = target > ele.offsetLeft ? 10 : -10;
        ele.timer = setInterval(function () {
            var val = target - ele.offsetLeft;
            ele.style.left = ele.offsetLeft + speed + "px";
            if (Math.abs(val) < Math.abs(speed)) {
                ele.style.left = target + "px";
                clearInterval(ele.timer);
            }
        }, 10)
    }

}