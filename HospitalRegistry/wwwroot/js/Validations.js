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

function ContainesOnlyNumbers() {
    var numbers = /^ [0 - 9] * $ /;
    if ((document.getElementById("IdCode").value.match(numbers))) {
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

function IsIdCodeInValid() {
    if (isNaN(document.getElementById("TxtFName").value)
        || (document.getElementById("TxtLName").value.length != 11)) {
        return "Wrong length. ID Code contains 11 numbers!";
    }
    return ""; 
}

function IsValid() 
{
    var FieldEmptymessage = IsFieldEmpty();
    var OnlyLettersmessage = ContainesOnlyLetters();
    var LengthIsValidMessage = LengthIsValid();
    var IsIdCodeInValidMessage = IsIdCodeInValid();
    var FinalErrorMessage = "Errors:";

    if (FieldEmptyEmptyMassage != "")
        FinalErrorMessage += "\n" + FieldEmptyEmptyMessage;
    if (OnlyLettersMessage != "")
        FinalErrorMessage += "\n" + OnlyLettersMessage;
    if (LenghtIsValidMessage != "")
        FinalErrorMessage += "\n" + LenghtIsValidMessage;
    if (IsIdCodeInValidMessage != "")
        FinalErrorMessage += "\n" + IsIdCodeInValidMessage;
    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    } else {
        return true;
    }

}


if (FinalErrorMessage != "Errors:") {
    alert(FinalErrorMessage);
    return false;
} else {
    return true;
}