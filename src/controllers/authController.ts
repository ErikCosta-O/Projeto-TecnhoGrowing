import { Request, Response } from "express"
import { Voluntario } from "../models/Voluntario"

import bcrypt from 'bcrypt'

//rotas de visualização login e register
export const login = (req:Request, res:Response) =>{

    res.render('pages/login')
}

export const contaUsuario = (req:Request, res:Response) =>{

    const message = req.flash('message')
    //console.log(error)

    res.render('pages/contaUsuario',{message})
}

export const contaUsuarioPost = async (req:Request, res:Response) =>{
    //verificando as validações do usuário

    //recebendo as informações do usuário via body (POST)
    const {nome,dataNascimento,email,password,cpf,telefone,experiencia,url,confirmpassword} = req.body

    //se password for diferente de confirmpassword
    if(password != confirmpassword){
        //enviar uma mensagem de erro ao usuário com flashmessage
        
        req.flash('message','As senhas não conferem, tente novamente.')

        res.redirect('/contaUsuario')
        
        return 
    }
    
    //checar se o usuário existe
    const checkIfUserExists = await Voluntario.findOne({

        where:{email:email}

    })

    //se o usuário existir exibir uma flash message
    if(checkIfUserExists){
        req.flash('message','O e-mail já está em uso')
        res.redirect('/contaUsuario')

        return
    }

    //criar o password

    /*vamos dificultar a senha para o hacker não conseguir 
    quebrar a senha , então vamos por 10 caracteres randomicos */

    const salt = bcrypt.genSaltSync(10)
    //gerar a hash com o meu salt para o usuário 
    const hashedPassword = bcrypt.hashSync(password,salt)

    /*agora vamos criar um objeto de usuário 
    com os dados recebidos */
  

    try{
        /* criando o usuário no banco */
        const user = await Voluntario.create({
            nome,
            dataNascimento,
            email,
            password: hashedPassword,
            cpf,
            telefone,
            experiencia,
            url
        })

        // nome,dataNascimento,email,password,cpf,telefone,experiencia,url,confirmpassword
        //const createdUser = await User.create(user);
        //inicializar a sessão
        //req.session.userId = createdUser.id;

        req.session.userId = JSON.stringify(user.id)


        req.flash('message','cadastro realizado com sucesso')

        //salvar a sessão
        //para garantir que meu usuário seja salvo
        //antes de redirecioná-lo para /
        req.session.save(() =>{
            res.redirect('/')
        })


    } catch(err){
        console.log(err)
    }
}