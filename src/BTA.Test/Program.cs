var result = buffer.OnKey(vk);

if (result is not null)
{
    SendInputHelper.Backspace(result.OriginalLength);
    SendInputHelper.TypeText(result.Text);
    SendInputHelper.TypeText(" ");
}