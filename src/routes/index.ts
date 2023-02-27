import { Router } from 'express'
import {Request, Response} from 'express'

import * as homeController from '../controllers/HomeController'
import * as userController from '../controllers/userController'
import * as ongController from '../controllers/ongController'
import * as authController from '../controllers/authController'

const router = Router()

router.get('/',homeController.home)

router.get('/perfil',homeController.perfil)

router.get('/sobre',homeController.sobre)

router.get('/vagas',homeController.vagas)

router.get('/vaga', homeController.vaga)

router.get('/loja',homeController.loja)

router.get('/contato',homeController.contato)

router.get('/confirma', homeController.confirma)

router.get('/finalizado',homeController.finalizado)

router.get('/404',homeController.erro)

router.get('/obrigado',homeController.obrigado)

router.get('/vaga-finalizada',homeController.vagaCriada)

router.get('/criar-conta-ong',ongController.contaOng)

router.get('/criar-vaga',ongController.criarVaga)

router.get('/criar-conta-voluntario',userController.contaUsuario)

//rotas de visualização login e register
router.get('/login',authController.login)

router.get('/contaUsuario',authController.contaUsuario)

//criando o post do register
router.post('/contaUsuario',authController.contaUsuarioPost)


export default router