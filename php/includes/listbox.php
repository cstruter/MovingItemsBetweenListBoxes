<?php

require_once("controls.php");

class listbox extends controls
{	
	var $items = array();
	
	function listbox($id)
	{
		$this->attributes["id"] = $id;
		$this->attributes["multiple"] = "multiple";		
	}
	
	function clear()
	{
		$this->items = array();
	}
	
	function addItem($text, $value)
	{
		$this->items[urldecode($text)] = urldecode($value);
	}

	function render()
	{		
		$html = '<select'.$this->setAttributes().">\n";		
		foreach($this->items as $text => $value)
		{
			$html.='<option value="'.htmlentities($value, ENT_QUOTES, 'UTF-8').'">'.htmlentities($text, ENT_QUOTES, 'UTF-8').'</option>'."\n";
		}		
		return $html.'</select>';
	}
}

?>