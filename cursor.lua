-- Initialize the cursor position
cursor_x = 0
cursor_y = 0
-- Function to handle key input
function handle_key_input(key)
    local x, y = cursor_x, cursor_y
    if key == 'h' then
        x = x - 1
    elseif key == 'j' then
        y = y + 1
    elseif key == 'k' then
        y = y - 1
    elseif key == 'l' then
        x = x + 1
    end
    cursor_x, cursor_y = x, y
end
-- Register the function to be called on key press
function register_key_handler()
    handle_key_input(key_input)
end
-- Set the global variables
key_input = ""
cursor_x = 0
cursor_y = 0
