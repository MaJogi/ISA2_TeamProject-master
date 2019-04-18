function IsFieldEmpty() {
    if ((document.getElementById("TxtFName").value == "")
        || (document.getElementById("TxtLName").value == "")
        || (document.getElementById("TxtIdCode").value == "")) {
        return "Required field!";}
    return "";
}

function ContainesOnlyLetters() {
    var letters =/^ [a - zA - Z] * $ /;
    if ((document.getElementById("TxtFName").value.match(letters))
        && (document.getElementById("TxtLName").value.match(letters))) {
        return "";
    }
    return "Use only letters!";
}







function LengthIsValid() {
    if ((document.getElementById("TxtFName").value.length > 20)
        || (document.getElementById("TxtLName").value.length > 20)) {
        return "Length should be less than 20 characters";
    }
    return "";

}

var IdCodeLenght = 11

function IsIDCodeInValid() {
    if ((document.getElementById("TxtFName").value.length > 20)
        || (document.getElementById("TxtLName").value.length > 20)) {
        return "Length should be less than 20 characters";
    }
    return ""; isNaN(document.getElementById("TxtIdCode").value)

}

