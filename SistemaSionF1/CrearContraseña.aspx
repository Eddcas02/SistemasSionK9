<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearContraseña.aspx.cs" Inherits="SistemaSionF1.CrearContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href='https://fonts.googleapis.com/css?family=Pacifico' rel='stylesheet' type='text/css' />
<link href='https://fonts.googleapis.com/css?family=Arimo' rel='stylesheet' type='text/css' />
<link href='https://fonts.googleapis.com/css?family=Hind:300' rel='stylesheet' type='text/css' />
<link href='https://fonts.googleapis.com/css?family=Open+Sans+Condensed:300' rel='stylesheet' type='text/css' />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width,initial-scale=1,shrink-to-fit=no">
    <meta name="description" content="Control de Pagos Grupo Sion">
    <meta name="author" content="Pendrogon IT">
    <meta name="keyword" content="Bootstrap,Admin,Template,Open,Source,CSS,SCSS,HTML,RWD,Dashboard,React">
    <link rel="shortcut icon" href="./GrupoSion.ico">
    <link href="https://cdn.webdatarocks.com/latest/theme/lightblue/webdatarocks.min.css" rel="stylesheet">
    <script src="https://cdn.webdatarocks.com/latest/webdatarocks.toolbar.min.js"></script>
    <script src="https://cdn.webdatarocks.com/latest/webdatarocks.js"></script>
    <link href="static/css/14.c5408309.chunk.css" rel="stylesheet">
    <link href="static/css/main.19eea11c.chunk.css" rel="stylesheet"/>

    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
       <div id="root">
        <div class="bg-light min-vh-100 d-flex flex-row align-items-center">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-md-9">
                        <div class="card-group">
                            <div class="card p-4">
                                <div class="card-body">
                                    <form class="">
                                        <h1>Actualizar Contraseña</h1>
                                        <p class="text-medium-emphasis">Cambiar contraseña antes de ingresar al sistema</p>
                                        <div class="input-group mb-4"><span class="input-group-text"><svg
                                                    stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <rect x="3" y="11" width="18" height="11" rx="2" ry="2"></rect>
                                                    <path d="M7 11V7a5 5 0 0 1 10 0v4"></path>
                                                </svg></span><asp:TextBox CssClass="form-control" type="password" id="ContraseñaAntigua" runat="server" placeholder="Ingrese contraseña actual" />
                                            <button class="btn btn-outline-secondary"
                                                type="button"><svg stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <path d="M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z"></path>
                                                    <circle cx="12" cy="12" r="3"></circle>
                                                </svg></button></div>
                                        <div class="input-group mb-4"><span class="input-group-text"><svg
                                                    stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <rect x="3" y="11" width="18" height="11" rx="2" ry="2"></rect>
                                                    <path d="M7 11V7a5 5 0 0 1 10 0v4"></path>
                                                </svg></span><asp:TextBox CssClass="form-control" type="password" id="ContraseñaNueva" runat="server" placeholder="Ingrese nueva contraseña" />
                                            <button class="btn btn-outline-secondary"
                                                type="button"><svg stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <path d="M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z"></path>
                                                    <circle cx="12" cy="12" r="3"></circle>
                                                </svg></button></div>

                                        <div class="input-group mb-4"><span class="input-group-text"><svg
                                                    stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <rect x="3" y="11" width="18" height="11" rx="2" ry="2"></rect>
                                                    <path d="M7 11V7a5 5 0 0 1 10 0v4"></path>
                                                </svg></span><asp:TextBox CssClass="form-control" type="password" id="ContraseñaNueva2" runat="server" placeholder="Confirmar nueva contraseña" />
                                            <button class="btn btn-outline-secondary"
                                                type="button"><svg stroke="currentColor" fill="none" stroke-width="2"
                                                    viewBox="0 0 24 24" stroke-linecap="round" stroke-linejoin="round"
                                                    height="1em" width="1em" xmlns="http://www.w3.org/2000/svg">
                                                    <path d="M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z"></path>
                                                    <circle cx="12" cy="12" r="3"></circle>
                                                </svg></button></div>
                                        <div class="row">
                                            <div class="col-6">
                                                
                                                <asp:LinkButton OnClick="iniciarsesion_Click" Text="Iniciar Sesión" CssClass="btn btn-primary px-4"  runat="server" />
                                               <%-- <button runat="server" class="btn btn-primary px-4"
                                                    type="submit" onclick="iniciar_sesion()">Iniciar Sesión</button>--%>

                                            </div>
                                           <%-- <div class="col-6 text-right"><button class="btn btn-link px-4"
                                                    type="button" onclick="cambiarcontra()">Olvidaste la contraseña?</button></div>--%>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <div class="card text-blue py-5">
                                <div class="card-body text-center">
                                    <div
                                        style="display: flex; flex-direction: column; align-items: center; justify-content: center;">
                                        <div style="width: 80%; height: 80%; background-color: transparent;"><img
                                                src="./static/media/logo.739acbb1.png" style="width: 80%;"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <script src='https://cdnjs.cloudflare.com/ajax/libs/gsap/1.16.1/TweenMax.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
        <script  src="Diseño/scriptlogin.js"></script>
        <asp:LinkButton ID="iniciarsesion" runat="server" OnClick="iniciarsesion_Click" ClientIDMode="Static" style="background: border-box;"></asp:LinkButton>
         <asp:LinkButton ID="cambiarcontraseña" runat="server" OnClick="cambiarcontra_Click" ClientIDMode="Static" style="background: border-box;"></asp:LinkButton>
    <script>!function (e) { function c(c) { for (var d, a, n = c[0], o = c[1], b = c[2], u = 0, l = []; u < n.length; u++)a = n[u], Object.prototype.hasOwnProperty.call(t, a) && t[a] && l.push(t[a][0]), t[a] = 0; for (d in o) Object.prototype.hasOwnProperty.call(o, d) && (e[d] = o[d]); for (i && i(c); l.length;)l.shift()(); return r.push.apply(r, b || []), f() } function f() { for (var e, c = 0; c < r.length; c++) { for (var f = r[c], d = !0, a = 1; a < f.length; a++) { var o = f[a]; 0 !== t[o] && (d = !1) } d && (r.splice(c--, 1), e = n(n.s = f[0])) } return e } var d = {}, a = { 13: 0 }, t = { 13: 0 }, r = []; function n(c) { if (d[c]) return d[c].exports; var f = d[c] = { i: c, l: !1, exports: {} }; return e[c].call(f.exports, f, f.exports, n), f.l = !0, f.exports } n.e = function (e) { var c = []; a[e] ? c.push(a[e]) : 0 !== a[e] && { 0: 1, 9: 1, 15: 1, 16: 1, 17: 1, 32: 1, 33: 1, 60: 1 }[e] && c.push(a[e] = new Promise((function (c, f) { for (var d = "static/css/" + ({}[e] || e) + "." + { 0: "9db0b797", 1: "31d6cfe0", 2: "31d6cfe0", 3: "31d6cfe0", 4: "31d6cfe0", 5: "31d6cfe0", 6: "31d6cfe0", 7: "31d6cfe0", 8: "31d6cfe0", 9: "f63c5ca7", 10: "31d6cfe0", 11: "31d6cfe0", 15: "83ac3116", 16: "3edd705f", 17: "4edd8ef9", 18: "31d6cfe0", 19: "31d6cfe0", 20: "31d6cfe0", 21: "31d6cfe0", 22: "31d6cfe0", 23: "31d6cfe0", 24: "31d6cfe0", 25: "31d6cfe0", 26: "31d6cfe0", 27: "31d6cfe0", 28: "31d6cfe0", 29: "31d6cfe0", 30: "31d6cfe0", 31: "31d6cfe0", 32: "83ac3116", 33: "325324c8", 34: "31d6cfe0", 35: "31d6cfe0", 36: "31d6cfe0", 37: "31d6cfe0", 38: "31d6cfe0", 39: "31d6cfe0", 40: "31d6cfe0", 41: "31d6cfe0", 42: "31d6cfe0", 43: "31d6cfe0", 44: "31d6cfe0", 45: "31d6cfe0", 46: "31d6cfe0", 47: "31d6cfe0", 48: "31d6cfe0", 49: "31d6cfe0", 50: "31d6cfe0", 51: "31d6cfe0", 52: "31d6cfe0", 53: "31d6cfe0", 54: "31d6cfe0", 55: "31d6cfe0", 56: "31d6cfe0", 57: "31d6cfe0", 58: "31d6cfe0", 59: "31d6cfe0", 60: "757a7212", 61: "31d6cfe0", 62: "31d6cfe0", 63: "31d6cfe0", 64: "31d6cfe0", 65: "31d6cfe0", 66: "31d6cfe0", 67: "31d6cfe0", 68: "31d6cfe0", 69: "31d6cfe0", 70: "31d6cfe0", 71: "31d6cfe0", 72: "31d6cfe0", 73: "31d6cfe0", 74: "31d6cfe0", 75: "31d6cfe0", 76: "31d6cfe0", 77: "31d6cfe0", 78: "31d6cfe0", 79: "31d6cfe0", 80: "31d6cfe0", 81: "31d6cfe0", 82: "31d6cfe0", 83: "31d6cfe0", 84: "31d6cfe0", 85: "31d6cfe0", 86: "31d6cfe0", 87: "31d6cfe0", 88: "31d6cfe0", 89: "31d6cfe0", 90: "31d6cfe0", 91: "31d6cfe0", 92: "31d6cfe0", 93: "31d6cfe0", 94: "31d6cfe0", 95: "31d6cfe0", 96: "31d6cfe0", 97: "31d6cfe0", 98: "31d6cfe0", 99: "31d6cfe0", 100: "31d6cfe0", 101: "31d6cfe0", 102: "31d6cfe0", 103: "31d6cfe0", 104: "31d6cfe0", 105: "31d6cfe0", 106: "31d6cfe0", 107: "31d6cfe0", 108: "31d6cfe0", 109: "31d6cfe0", 110: "31d6cfe0", 111: "31d6cfe0", 112: "31d6cfe0", 113: "31d6cfe0", 114: "31d6cfe0", 115: "31d6cfe0", 116: "31d6cfe0", 117: "31d6cfe0", 118: "31d6cfe0", 119: "31d6cfe0", 120: "31d6cfe0", 121: "31d6cfe0", 122: "31d6cfe0", 123: "31d6cfe0", 124: "31d6cfe0", 125: "31d6cfe0", 126: "31d6cfe0", 127: "31d6cfe0", 128: "31d6cfe0", 129: "31d6cfe0" }[e] + ".chunk.css", t = n.p + d, r = document.getElementsByTagName("link"), o = 0; o < r.length; o++) { var b = (i = r[o]).getAttribute("data-href") || i.getAttribute("href"); if ("stylesheet" === i.rel && (b === d || b === t)) return c() } var u = document.getElementsByTagName("style"); for (o = 0; o < u.length; o++) { var i; if ((b = (i = u[o]).getAttribute("data-href")) === d || b === t) return c() } var l = document.createElement("link"); l.rel = "stylesheet", l.type = "text/css", l.onload = c, l.onerror = function (c) { var d = c && c.target && c.target.src || t, r = new Error("Loading CSS chunk " + e + " failed.\n(" + d + ")"); r.code = "CSS_CHUNK_LOAD_FAILED", r.request = d, delete a[e], l.parentNode.removeChild(l), f(r) }, l.href = t, document.getElementsByTagName("head")[0].appendChild(l) })).then((function () { a[e] = 0 }))); var f = t[e]; if (0 !== f) if (f) c.push(f[2]); else { var d = new Promise((function (c, d) { f = t[e] = [c, d] })); c.push(f[2] = d); var r, o = document.createElement("script"); o.charset = "utf-8", o.timeout = 120, n.nc && o.setAttribute("nonce", n.nc), o.src = function (e) { return n.p + "static/js/" + ({}[e] || e) + "." + { 0: "204cb263", 1: "d0b17a3f", 2: "a4c1ce4e", 3: "7e51092e", 4: "5dd007d7", 5: "b61ee59b", 6: "84b76546", 7: "4843fe09", 8: "334d4c7e", 9: "96cbc34f", 10: "b41af190", 11: "2a8989ab", 15: "6d71f0b8", 16: "ebe56558", 17: "ca18002d", 18: "d6742bca", 19: "ab8b610d", 20: "17354ccc", 21: "8d44a429", 22: "d4493a7b", 23: "206bc12c", 24: "72f5faad", 25: "e71feb54", 26: "13e1e867", 27: "24705a55", 28: "f639b213", 29: "93f9582b", 30: "d9752280", 31: "396dfdfc", 32: "f7ab132c", 33: "a7038589", 34: "bbf1dead", 35: "e5bf9a9c", 36: "454e330d", 37: "a803d2ad", 38: "bdf96ff5", 39: "dac2a6b0", 40: "ec868b7c", 41: "c465c4af", 42: "a536830d", 43: "83120cda", 44: "edd1e14a", 45: "89ec1741", 46: "7e182f75", 47: "f53a205e", 48: "6b3d7aaa", 49: "b7319185", 50: "31c23c8f", 51: "31fc1163", 52: "262c68fb", 53: "82c3f3bc", 54: "aed427d5", 55: "594baf8e", 56: "76a015f5", 57: "b2129d4a", 58: "c047d473", 59: "d7b03ff2", 60: "7891274f", 61: "d2bd89de", 62: "81ac4e8c", 63: "ab5c73ee", 64: "cb1692e7", 65: "15f05694", 66: "7b331b60", 67: "0f677918", 68: "dae51e64", 69: "540bb27f", 70: "daa7b9e8", 71: "f64d4c16", 72: "11f7a860", 73: "91511aba", 74: "a1f22bf4", 75: "47341cbe", 76: "def9a5fb", 77: "cd39ad3b", 78: "ef633d20", 79: "3866aeba", 80: "92e18433", 81: "91790256", 82: "b3a74862", 83: "863c21df", 84: "afabeb51", 85: "5aeca332", 86: "acf7b8a4", 87: "ee94f2c6", 88: "fb90b9dc", 89: "e10c6ad1", 90: "7a248fa7", 91: "487dbb21", 92: "ed087999", 93: "9973e857", 94: "44e3dc7c", 95: "f031ad5b", 96: "d6a4e68e", 97: "081effac", 98: "7d697a18", 99: "f09541fd", 100: "bf1eabb6", 101: "5712fdbd", 102: "e2c02b41", 103: "cf85f94d", 104: "ab5e099e", 105: "61a6c6d1", 106: "e9cdc5d6", 107: "a10e9845", 108: "66e28105", 109: "28088974", 110: "01c38d21", 111: "1526752a", 112: "77ee3b19", 113: "d24878ad", 114: "d0752dc2", 115: "8efb67ea", 116: "766d3915", 117: "c352bfa2", 118: "720735b1", 119: "345d00e2", 120: "b72759a5", 121: "73de0a3a", 122: "da2f344c", 123: "5042b306", 124: "87c35dfd", 125: "f3c407e6", 126: "c43aeaef", 127: "7f4f54ef", 128: "7edd036c", 129: "322fa6ac" }[e] + ".chunk.js" }(e); var b = new Error; r = function (c) { o.onerror = o.onload = null, clearTimeout(u); var f = t[e]; if (0 !== f) { if (f) { var d = c && ("load" === c.type ? "missing" : c.type), a = c && c.target && c.target.src; b.message = "Loading chunk " + e + " failed.\n(" + d + ": " + a + ")", b.name = "ChunkLoadError", b.type = d, b.request = a, f[1](b) } t[e] = void 0 } }; var u = setTimeout((function () { r({ type: "timeout", target: o }) }), 12e4); o.onerror = o.onload = r, document.head.appendChild(o) } return Promise.all(c) }, n.m = e, n.c = d, n.d = function (e, c, f) { n.o(e, c) || Object.defineProperty(e, c, { enumerable: !0, get: f }) }, n.r = function (e) { "undefined" != typeof Symbol && Symbol.toStringTag && Object.defineProperty(e, Symbol.toStringTag, { value: "Module" }), Object.defineProperty(e, "__esModule", { value: !0 }) }, n.t = function (e, c) { if (1 & c && (e = n(e)), 8 & c) return e; if (4 & c && "object" == typeof e && e && e.__esModule) return e; var f = Object.create(null); if (n.r(f), Object.defineProperty(f, "default", { enumerable: !0, value: e }), 2 & c && "string" != typeof e) for (var d in e) n.d(f, d, function (c) { return e[c] }.bind(null, d)); return f }, n.n = function (e) { var c = e && e.__esModule ? function () { return e.default } : function () { return e }; return n.d(c, "a", c), c }, n.o = function (e, c) { return Object.prototype.hasOwnProperty.call(e, c) }, n.p = "./", n.oe = function (e) { throw console.error(e), e }; var o = this["webpackJsonp@coreui/coreui-free-react-admin-template"] = this["webpackJsonp@coreui/coreui-free-react-admin-template"] || [], b = o.push.bind(o); o.push = c, o = o.slice(); for (var u = 0; u < o.length; u++)c(o[u]); var i = b; f() }([])</script>
    <script src="static/js/14.433a598c.chunk.js"></script>
    <script src="static/js/main.30072fac.chunk.js"></script>
        <script type="text/javascript">
            function iniciar_sesion2() {
                iniciar_sesion();
            }
            function iniciar_sesion() {
                document.getElementById('iniciarsesion').click();
            }
            function cambiarcontra() {
                document.getElementById('cambiarcontraseña').click();
            }

        </script>
    <script type="text/javascript">
        window.location.hash = "no-back-button";

        window.location.hash = "Again-No-back-button";//esta linea es necesaria para chrome

        window.onhashchange = function () { window.location.hash = "no-back-button"; }


    </script>
    </form>
</body>
</html>
