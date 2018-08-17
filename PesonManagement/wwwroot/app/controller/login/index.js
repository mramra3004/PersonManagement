﻿var LoginController = function () {
    this.initialize = function () {
        registerEvents();
    }
    var login = function (user, pass) {
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: pass
            },
            dateType: 'json',
            url: '/admin/login/authen',
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Admin/Home/Index";
                } else {
                    util.notify('Login failed', 'error');
                }
            }
        });
    }
    var registerEvents = function () {
        $('#btnLogin').off('click').on('click', function () {
            var user = $('#txtUserName').val();
            var password = $('#txtPassword').val();
            login(user, password);
        });
    }
}