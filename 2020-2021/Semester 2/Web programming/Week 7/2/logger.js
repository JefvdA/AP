class Logger {

    Info(message){
        console.log(`Info: ${message}`)
    }

    Warning(message){
        console.warn(`Warning: ${message}`)
    }

    Error(message){
        console.error(`Error: ${message}`)
    }
}
module.exports = Logger
