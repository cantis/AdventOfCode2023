# Advent of Code day 1
def calc_calebration(input_string: str) -> int:
    """Calculate the calebration value from the input string."""
    #find the first number in the input string
    first_num = 0
    last_num = 0

    # modified_input_string = number_replace(input_string)
    modified_input_string = input_string
    length = len(modified_input_string)

    #find the first number in the input string
    for i in range(0, length - 1, 1):
        if modified_input_string[i].isnumeric():
            first_num = modified_input_string[i]
            break

    for i in range(length - 1, 0, -1):
        if modified_input_string[i].isnumeric():
            last_num = modified_input_string[i]
            break


    str_calebration_value =  str(first_num) + str(last_num)
    return int(str_calebration_value)

def number_replace(input_string: str) -> str:
    """Replace the text numbers with the actual numbers."""
    input_string = input_string.replace('one', '1')
    input_string = input_string.replace('two', '2')
    input_string = input_string.replace('three', '3')
    input_string = input_string.replace('four', '4')
    input_string = input_string.replace('five', '5')
    input_string = input_string.replace('six', '6')
    input_string = input_string.replace('seven', '7')
    input_string = input_string.replace('eight', '8')
    input_string = input_string.replace('nine', '9')
    input_string = input_string.replace('zero', '0')
    return input_string


if __name__ == '__main__':
    total_result = 0
    with open('./day1/input_values.txt', 'r') as file:
        for line in file:
            result = calc_calebration(line)
            print(f'{line} - {result}')
            total_result += result
    print('Total result: ', total_result)