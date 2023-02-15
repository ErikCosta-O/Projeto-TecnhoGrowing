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

router.get('/loja',homeController.loja)

router.get('/contato',homeController.contato)

router.get('/confirmCad',homeController.confirmCad)

router.get('/cadFinalizado',homeController.cadFinalizado)

router.get('/criarContaOng',ongController.contaOng)

router.get('/contaOng',ongController.contaOng)

//rotas de visualização login e register
router.get('/login',authController.login)

router.get('/contaUsuario',authController.contaUsuario)

//criando o post do register
router.post('/contaUsuario',authController.contaUsuarioPost)


export default router