# from PIL import Image
# im = Image.new('RGB', (1024, 1024))
# im.putdata([(255,0,0), (0,255,0), (0,0,255)])
# im.save('test.png')

import os
from PIL import Image
import numpy


def parse_gfx_file(_filename):
    print(_filename)

    file1 = open(_filename, 'r')
    lines = file1.readlines()

    # Strips the newline character
    count = 0
    row_count = 0
    max_x_count = 0

    for line in lines:
        if line.startswith(';'):
            continue

        if (line.find(':')) != -1:
            # found label, which defines a sprite; restart counter;
            if count != 0:
                print("count: {}, y: {}, x: {}".format(count, row_count, max_x_count))
            count = 0
            row_count = 0

        if line.find('db') != -1:
            row_count += 1
            second = line.split('db')[1]
            items = second.split(',')
            if len(items) > max_x_count:
                max_x_count = len(items)

            for item in items:
                # print(item.strip())
                count += 1
            # print(second)

    print("count: {}, y: {}, x: {}".format(count, row_count, max_x_count))

    return


directory = os.path.abspath('../gfx/')

# print(directory)

for file in os.listdir(directory):
    filename = os.fsdecode(file)
    # print(filename)
    if filename.endswith(".asm"):
        path = os.path.join(directory, filename)
        parse_gfx_file(path)
        continue
    else:
        continue

exit(1)

data = numpy.zeros((512, 512, 3), dtype=numpy.uint8)
for x in range(512):
    data[x, x] = [x / 2, x / 2, x / 2]

image = Image.fromarray(data)
image.show()
