function IsFieldEmpty() {
    if ((document.getElementById("TxtFName").value == "")
        || (document.getElementById("TxtLName").value == "")
        //|| (document.getElementById("TxtValidFrom").value == DateTime.MinValue) // Date From Error Message
        //|| (document.getElementById("TxtValidTo").value == null)                // Date To Error Message
        || (document.getElementById("TxtIdCode").value == "")) {
        return "Required field!";
    }
    return "";
}

function ContainsOnlyLetters() {
    var letters = /^[a-zA-Z]+$/;
    if ((document.getElementById("TxtFName").value.match(letters))
        && (document.getElementById("TxtLName").value.match(letters))) {
        return "";
    }
    return "Use only *ENG* letters!";
}

function ContainsOnlyNumbers() {
    var numbers = /^\d+$/;
    if ((document.getElementById("TxtIdCode").value.match(numbers))) {
        return "";
    }
    return "Use only numbers!";
}


function LengthIsValid() {
    if ((document.getElementById("TxtFName").value.length > 20)
        || (document.getElementById("TxtLName").value.length > 20)) {
        return "Length should be less than 20 characters";
    }
    return "";

}

var IdCodeLenght = 11;

function IsIdCodeInValid() {
    if (document.getElementById("TxtIdCode").value.length != IdCodeLenght)
       {
        return "Wrong length. ID Code contains 11 numbers!";
    }
    return ""; 
}



//function IsFromEmpty() {
//    if (document.getElementById("TxtValidFrom").value == 0)
//         {
//        return "Please fill Date (From)";
//    }
//    return "";
//}


//function IsToEmpty() {
//    if (document.getElementById("TxtValidTo").value == null) {
//        return "Please fill Date (To)";
//    }
//    return "";
//}

function IsFieldProblemEmpty() {
    if (document.getElementById("TxtProblem").value == "")
        {
        return "Fill problem";
    }
    return "";
}


function IsValid() {
    var FieldEmptyMessage = IsFieldEmpty();
    var OnlyLettersMessage = ContainsOnlyLetters();
    var OnlyNumbersMessage = ContainsOnlyNumbers();
    var LengthIsValidMessage = LengthIsValid();
    var IsIdCodeInValidMessage = IsIdCodeInValid();
    //var IsFromEmptyMessage = IsFromEmpty();
    //var IsToEmptyMessage = IsToEmpty();
    var IsFieldProblemEmptyMessage = IsFieldProblemEmpty();
    var FinalErrorMessage = "Errors:";

    if (FieldEmptyMessage != "")
        FinalErrorMessage += "\n" + FieldEmptyMessage;
    if (OnlyLettersMessage != "")
        FinalErrorMessage += "\n" + OnlyLettersMessage;
    if (OnlyNumbersMessage != "")
        FinalErrorMessage += "\n" + OnlyNumbersMessage;
    if (LengthIsValidMessage != "")
        FinalErrorMessage += "\n" + LengthIsValidMessage;
    if (IsIdCodeInValidMessage != "")
        FinalErrorMessage += "\n" + IsIdCodeInValidMessage;
    //if (IsFromEmptyMessage != "")
    //    FinalErrorMessage += "\n" + IsFromEmptyMessage;
    //if (IsToEmptyMessage != "")
    //    FinalErrorMessage += "\n" + IsToEmptyMessage;
    if (IsFieldProblemEmptyMessage != "")
        FinalErrorMessage += "\n" + IsFieldProblemEmptyMessage;
    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    } else {
        return true;
    }

}