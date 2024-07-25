import Iterator
def __init__(self):
    thisX = self.x & self.y | self.z;
    thisY = self.y & self.x | self.z;
    thisZ = self.z & self.y | self.x;
def Nuclear_Core(mass):
    c = 299792458;
    cc = c*c;
    E = mass * cc;
