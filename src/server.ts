//servidor
import express  from 'express'
//variavel de ambiente (PORT)
import dotenv from 'dotenv'
//mustahce é o HTML
import mustache from 'mustache-express'
//path para poder usar a pasta public
import path from 'path'
//importando flash messages
import flash from 'connect-flash'
//importando session
import session from 'express-session'

//importando o arquivo index.ts
import mainRoutes from './routes/index'

dotenv.config()
//criando a variavel server para receber o express
const server = express()

//fazendo o declaration merging de userId
declare module 'express-session' {
    interface SessionData {
    userId: string,
    }
}

server.use(express.json());

//configurações do mustache
server.set('view engine','mustache')
server.set('views',path.join(__dirname,'views'))
server.engine('mustache',mustache())
//diretorio da pasta public
server.use(express.static(path.join(__dirname,'../public')))

server.use(express.urlencoded({ extended: true }));

//express session
server.use(
    session({
        name:'session',
        secret: "nosso_secret",
        resave: false,
        saveUninitialized: false,
        cookie: {
            secure: false,
            maxAge: 3600000,
            expires: new Date(Date.now() + 3600000),
            httpOnly: true
        }
    })
)
server.use(flash())

server.use((req, res, next) => {
    
    if(req.session.userId) {
        res.locals.session = req.session
    }

    next()
})

server.use(mainRoutes)

//escutando a porta do servidor
server.listen(process.env.PORT)