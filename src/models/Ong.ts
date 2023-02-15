import { StringifyOptions } from "querystring";
import { Model, DataTypes } from "sequelize";

import { sequelize } from "../instances/mysql";

export interface OngInstance extends Model{
    codOng: number,
    nome: String,
    email: String,
    tel: number,
    cnpj: number,
    numero: string,
    complemento: string,
    cep: string,
    bairro: string,
    cidade: string,
    categoria: String,
    descricao: String,
    webSite: String,
    redeSocial: String,
    url: String,
}

export const Ong = sequelize.define<OngInstance>("Ong,",{
    codOng:{
        primaryKey:true,
        type:DataTypes.INTEGER,
        allowNull:false
    },
    nome:{
        type:DataTypes.STRING,
        allowNull:false
    },
    email:{
        type:DataTypes.STRING,
        allowNull:false
    },
    tel:{
        type:DataTypes.INTEGER,
        allowNull:false
    },
    cnpj:{
        type:DataTypes.INTEGER,
        allowNull:false
    },
    endereco:{
        type:DataTypes.STRING,
        allowNull:false
    },
    categoria:{
        type:DataTypes.STRING,
        allowNull:false
    },
    descricao:{
        type:DataTypes.STRING,
        allowNull:false
    },
    webSite:{
        type:DataTypes.STRING,
        allowNull:false
    },
    redeSocial:{
        type:DataTypes.STRING,
        allowNull:false
    },
    codFunc:{
        type:DataTypes.INTEGER,
        allowNull:false
    },
    cep:{
        type:DataTypes.STRING,
        allowNull:false
    },
    bairro:{
        type:DataTypes.STRING,
        allowNull:false
    },
    cidade:{
        type:DataTypes.STRING,
        allowNull:false
    },
    complemento:{
        type:DataTypes.STRING,
        allowNull:false
    },


},{
    tableName:'tbONG',
    timestamps: false
})