
const param = {
    "EndDate": "2022-05-05",
    "IdEmployee": 23,
    "Name": "Desde la Web",
    "StartDate": "2022-05-05"
}

const fillDataTable = () => {
    $('#employee-list').DataTable({
        'ajax': {
            'url': 'Employee/list-param',
            'type': "GET",
            'contentType': 'application/json',
            'data': param
        },
        'columns': [
            { data: 'BusinessEntityID' },
            { data: 'NationalIDNumber' },
            { data: 'LoginID' },
            { data: 'OrganizationLevel' },
            { data: 'JobTitle' },
            { data: 'BirthDate' },
            { data: 'MaritalStatus' },
            { data: 'Gender' },
            { data: 'HireDate' },
            { data: 'SalariedFlag' },
            { data: 'VacationHours' },
            { data: 'SickLeaveHours' },
            { data: 'CurrentFlag' },
            { data: 'rowguid' },
            { data: 'ModifiedDate' },
            { data: 'ImagePath' }
        ]
    });
}

const employeeList = () => {
    $.ajax({
        url: "Employee/List",
        success: (result) => {
            return result
        }
    });
}



