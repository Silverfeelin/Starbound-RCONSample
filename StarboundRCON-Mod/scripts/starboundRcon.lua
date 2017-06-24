-- Keys in the commands table should be lowercase!
local commands = {}

function init()

end

-- RCON (and in-game commands) arrive here.
function command(name, clientId, args)
  -- RCON client ID is 0. Return if command was called in-game.
  if clientId ~= 0 then return "" end

  local returnValue = "Command not found.";

  -- Call command
  if commands[name:lower()] then
    returnValue = commands[name](clientId, table.unpack(args))
  end

  -- Ensure valid response.
  if type(returnValue) ~= "string" or returnValue == "" then
    returnValue = "Empty response."
  end

  -- Log RCON.
  sb.logInfo("RCON (%s): %s", name, returnValue)

  return returnValue
end

-- Sample commands
function commands.testrcon()
  return "The server StarboundRCON mod responsed!"
end