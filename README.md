# shacks

# Server

The server is a basic flask app. The entry point /nutri/ takes a post request with the field 'image', whose value is a base64 encoding of an image.
It will then do some basic image processing, send it to cloudvision for feature detection, attempt to isolate something vaguely food related, then find the corresponding nutritional information from the USDA Food Database.

Returns calories, fat, protein, fiber in JSON

# Client

The client is a unity AR app; once Google ARCore detects a valid surface, users can tap the screen, which send camera data to the server. The data is then presented with *augmented reality wooowhowwofawh~~~~a;skjfaaweafajds* 
