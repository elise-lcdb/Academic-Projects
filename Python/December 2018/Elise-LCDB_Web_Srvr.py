import socket
import os
import re

#Defining the Socket Variables
port = input("Enter the port number you would like to use: ")
host = '127.0.0.1'

#Defining the response I want to send back
ok_status = 'HTTP/1.0 200 OK\n'
error_status = 'HTTP/1.0 404 NOT FOUND\n'
content_type = 'Content-Type: text/html\n'

#Defining the HTML file I want to read. Raw_Input used due to computer issues with the normal input. Could be an issue with python versions?
path = os.path.dirname(os.path.abspath(__file__))
foldername = raw_input('Please enter the folder name of your website located in the www folder:\n')
path = path + '/www/' + foldername
allfiles = os.listdir(path)


#Starting the socket
srvr = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
srvr.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
srvr.bind((host,port))
srvr.listen(1)

while True:
    connect, addr = srvr.accept()
    srvr_request = connect.recv(1024)
    print (srvr_request)
    GETDATA = re.search('GET /(.*) HTTP/', srvr_request)
    for eachfile in allfiles:
        if GETDATA.group(1) == "":
            html_file = path + '/index.html'
            #Fetching the contents of the HTML file
            f_html = open(html_file, "r")
            #checking if we are allowed to read a file
            if f_html.mode == "r":
                file_contents = f_html.read()
            #The section above concerning reading an html file is inspired by: https://www.guru99.com/reading-and-writing-files-in-python.html
        elif GETDATA.group(1) == eachfile:
            html_file = path + '/' + eachfile
            f_html = open(html_file, "r")
            if f_html.mode == "r":
                file_contents = f_html.read()
        elif (GETDATA.group(1) != eachfile) or (GETDATA.group(1) != ""):
            file_contents = "Page not Found"
            ok_status = error_status
    
    connect.send(ok_status)
    connect.send(content_type)
    connect.send('\n')
    connect.send(file_contents)
    connect.close()
