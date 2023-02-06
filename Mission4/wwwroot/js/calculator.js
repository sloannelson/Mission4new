
document.getElementById("btnSend").addEventListener("click", function () {


    var grade1 = parseFloat(document.getElementById("A").value * 0.5);
    var grade2 = parseFloat(document.getElementById("G").value * 0.1);
    var grade3 = parseFloat(document.getElementById("Q").value * 0.1);
    var grade4 = parseFloat(document.getElementById("M").value * 0.1);
    var grade5 = parseFloat(document.getElementById("F").value * 0.1);
    var grade6 = parseFloat(document.getElementById("I").value * 0.1);

    finalgrade = grade1 + grade2 + grade3 + grade4 + grade5 + grade6

    if (finalgrade > 94) {
        alert("A")
    }
    else if (finalgrade >= 90) {
        alert("A-")
    }
    else if (finalgrade >= 87) {
        alert("B+")
    }
    else if (finalgrade >= 84) {
        alert("B")
    }
    else if (finalgrade >= 80) {
        alert("B-")
    }
    else if (finalgrade >= 77) {
        alert("C+")
    }
    else if (finalgrade >= 74) {
        alert("C")
    }
    else if (finalgrade >= 70) {
        alert("C-")
    }
    else if (finalgrade >= 67) {
        alert("D+")
    }
    else if (finalgrade >= 64) {
        alert("D")
    }
    else if (finalgrade >= 60) {
        alert("D-")
    }
    else if (finalgrade < 60) {
        alert("E")
    }
    

})




