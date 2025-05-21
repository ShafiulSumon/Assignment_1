using System;

namespace Assignment_1.Utils;

public class ConstantMessage
{
    public const int Port = 587;
    public const string Host = "smtp.gmail.com";
    public const string EmailFrom = "Team Ostad";
    public const string EmailSubject = "Registration Completed";
    public const string EmailBody = @"<!DOCTYPE html>
        <html>
        <head>
        <style>
            body {
            font-family: Arial, sans-serif;
            color: #333;
            }
            .container {
            max-width: 600px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 10px;
            background-color: #f9f9f9;
            }
            .footer {
            font-size: 12px;
            color: #888;
            margin-top: 20px;
            }
        </style>
        </head>
        <body>
        <div class=""container"">
            <p>Dear user,</p>
            <p><strong>Your registration has been completed!</strong> You can now proceed.</p>
            <p class=""footer"">
            This is an auto-generated email by the system.<br>
            Thanks,<br>
            <strong>Team Ostad</strong>
            </p>
        </div>
        </body>
        </html>
        ";

}
