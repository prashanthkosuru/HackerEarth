var http = require('http');

http.createServer(function (req, res) {// the callback handles the request
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    if (req.url === '/file.txt') {
        fs.createReadStream(__dirname + '/file.txt').pipe(res);
    } else {
        res.end("Hello world");
    }
}).listen(process.env.PORT, process.env.IP);
